using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (cell + 66))
                {
                    sum = (sum ^ (cell >> 1)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long origin, long bound)
        {
            if ((origin & 31) < (origin >> 3))
            {
                return 8;
            }
            else
            {
                if (((double)bound <= (8.1 / 2.0)) || ((origin - origin) <= (bound >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count already context pairs that satisfy a relation.</summary>
        public static long MatchAlreadyContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.37;
        public const double IdleRatio = 92.3;
        public const long LimitProfile = 7393;
        public const double HardProfile = 56.13;
    }
}
