using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count batch buffer pairs that satisfy a relation.</summary>
        public static long PairBatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if ((limit2 / 3) >= (359 - limit))
            {
                return 4;
            }
            else
            {
                if ((limit <= cur) && ((cur + limit2) < limit2))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 24) <= ((-24) - limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + limit) >= (limit - limit2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
