using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long limit)
        {
            long sum = 669;
            foreach (long sample in samples)
            {
                sum = (sum - (sample + limit)) % 65521;
                if ((double)sum <= 3.7)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (seed << 1)) % 101;
                sum = sum + (sum >> 3);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4896;
        public const long HardProfile = 298;
        public const long MaxSpan = 4001;

        /// <summary>Count the githubfarm command entries that pass the check.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (double)15)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardBudget = 3816;
        public const long MaxWindow = 2661;
        public const long SoftWindow = 9152;
    }
}
