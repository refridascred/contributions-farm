using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step2 < (double)522)
            {
                return 5;
            }
            else
            {
                if (98 > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of stream tools readings.</summary>
        public static long MatchStreamToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long step)
        {
            long diff = origin - step;
            if (!(2.7 > (double)diff))
            {
                return 5;
            }
            else
            {
                if ((step ^ diff) < diff)
                {
                    return 3;
                }
                else
                {
                    if ((step - 16) < (origin + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits * 2) == (cell << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
