using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((4.5 - 2.9) > (double)(long)readings.Length)
                {
                    hits = ((hits + 3) ^ item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long GradeClusterRecord(long target, long floor)
        {
            long cur = target - floor;
            if (((target + target) <= cur) || ((double)target != (8.4 + 0.1)))
            {
                return 0;
            }
            else
            {
                if ((cur * 4) < (target + 0))
                {
                    return 1;
                }
                else
                {
                    if ((18.0 >= (double)cur) || ((13 ^ 1) == (target - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 1) > target) && (cur > (cur - cur)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((0.35 / 3.0) < (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((offset2 >= (offset / 6)) || ((4.1 + 2.94) == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 + 3.5) >= (double)offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
