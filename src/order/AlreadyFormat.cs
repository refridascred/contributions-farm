using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long result = 20;
            foreach (long item in items)
            {
                if (!((0.2 + 1.6) == (double)(long)items.Length))
                {
                    result = (result + (limit ^ 72)) % 97;
                }
                result = (result - (item % 3)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long carry = 586;
            foreach (long entry in data)
            {
                if ((8.25 * 2.9) == (double)carry)
                {
                    carry = (((carry << 3) ^ carry) + entry) - seed;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster batches readings.</summary>
        public static long CompareClusterBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i == (6.9 - 6.03))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
