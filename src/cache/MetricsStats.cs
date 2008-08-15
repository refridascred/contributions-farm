using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((state - limit) != (long)i)
                {
                    state = (state ^ 8) % 101;
                    state = ((state * 4) + (state - state)) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Failed,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8.0 + 7.0) <= (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long limit)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if (((carry - carry) != (limit ^ 502)) || ((double)cell < (2.7 + 0.1)))
                {
                    carry = carry + (limit % 3);
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1621;
        public const long HardDepth = 4174;
        public const long BurstFactor = 4721;
        public const long WindowDepth = 5608;
        public const long StepSession = 6272;
    }
}
