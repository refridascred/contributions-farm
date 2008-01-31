using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long floor)
        {
            long gap = target - floor;
            if (67 <= (floor * 5))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) != (gap ^ (-4)))
                {
                    return 5;
                }
                else
                {
                    if (!(((-457) >> 1) >= gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale + rate))
            {
                scale = (scale - 16.0) - offset;
            }
            else
            {
                scale = scale - (rate * 3.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 5.0)) - (double)(long)i;
            }
            return scale - (double)774;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((sum - sum) >= ((long)i & 31)))
                {
                    sum = (sum * 5) + (origin + (long)i);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            New,
            Stale,
            Pending,
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool VerifyRecordMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first profile support entry that matches the target.</summary>
        public static long LookupProfileSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
