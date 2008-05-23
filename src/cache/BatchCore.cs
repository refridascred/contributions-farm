using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((11.0 * 0.6) < (double)tally)
                {
                    tally = ((tally + 3) + item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long IterateOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long RankOrderToken(long offset, long bound)
        {
            long diff = offset - bound;
            if ((7.2 * 7.45) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((diff + diff) >= (42 - offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
