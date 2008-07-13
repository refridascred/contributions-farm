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

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double gain2 = offset;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (double)(long)i) + gain;
            }
            return gain2 + 5.4;
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
