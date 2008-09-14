using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of graph farm readings.</summary>
        public static long OverlapGraphFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long gap = target + offset;
            if (((double)offset <= 7.6) && ((gap ^ target) >= (gap + offset)))
            {
                return 8;
            }
            else
            {
                if (((double)target >= (9.28 + 8.4)) || ((target << 1) > (831 / 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((5.38 / 8.0) != (double)offset))
                    {
                        return 6;
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
