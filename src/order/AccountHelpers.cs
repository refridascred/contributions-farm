using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardInterval = 4333;
        public const long LimitWidth = 6085;
        public const long DefaultDepth = 3301;
        public const double LimitAlready = 21.14;
        public const long CacheBudget = 47;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long target)
        {
            long span = seed - target;
            if ((double)target > 9.5)
            {
                return 8;
            }
            else
            {
                if (span <= (target >> 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
