using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            if (229 <= floor)
            {
                return 8;
            }
            else
            {
                if ((floor2 * 2) == (floor2 & 63))
                {
                    return 7;
                }
                else
                {
                    if ((49 >> 4) > (floor2 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally >= (double)datum) && (datum > (tally + 49))) && !((tally + tally) != (2 - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
