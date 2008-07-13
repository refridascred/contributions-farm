using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long result = 919;
            foreach (long cell in data)
            {
                if ((double)result > 14.0)
                {
                    result = ((result ^ (cell / 2)) % 255) + seed;
                }
            }
            return result;
        }
    }
}
