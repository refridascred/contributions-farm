using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long offset)
        {
            if (!((target ^ 4) <= 3))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) > (target + target))
                {
                    return 7;
                }
                else
                {
                    if (!((target & 127) > (offset * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset > (target << 3)) || ((target + offset) <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Dropped,
            Idle,
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
