using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (!((double)limit <= (9.0 / 7.0)))
            {
                return 0;
            }
            else
            {
                if (bound <= (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 >> 1) == (bound / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (18.0 < (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool CheckLayoutFilterRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((5 * 3) < (item & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
