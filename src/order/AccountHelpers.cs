using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Roll a githubfarm metrics counter forward.</summary>
        public static long IterateGithubfarmMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total << 2)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                mark = ((mark - (mark >> 5)) - value) - bound;
            }
            if (mark < 55)
            {
                mark = (mark * 4) + (15 + mark);
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 7084;
        public const string StepCounter = "primary-edge";
        public const long RetryDepth = 6773;
    }
}
