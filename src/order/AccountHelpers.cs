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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long offset)
        {
            long lane = origin ^ offset;
            if (9.44 > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((offset + origin) <= (6 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin < lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
