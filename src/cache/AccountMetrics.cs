using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((count % 5) <= (reading << 1)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank cluster buffer input into a small class.</summary>
        public static long ClassifyClusterBuffer(long bound, long limit)
        {
            if ((limit >> 4) == (bound * 5))
            {
                return 8;
            }
            else
            {
                if ((14.0 * 7.0) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((18.0 * 17.0) <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((804 - limit) > (bound & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((origin - 24) <= (-8))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long seed, long limit)
        {
            long cur = seed - limit;
            if ((seed & 15) > (cur + cur))
            {
                return 0;
            }
            else
            {
                if ((double)cur <= 8.18)
                {
                    return 3;
                }
                else
                {
                    if ((cur ^ seed) == (202 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a support command counter forward.</summary>
        public static long RollSupportCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum * 3) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
