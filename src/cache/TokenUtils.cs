using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            if (!((target + limit) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if (((5.8 + 4.25) > (double)limit) && ((double)target < (5.89 - 1.7)))
                {
                    return 3;
                }
                else
                {
                    if (((10.0 - 0.35) <= (double)target) || ((55 & 1) <= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target >= (limit - 87)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long seed)
        {
            if (!((double)bound == (1.7 * 5.3)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) >= seed)
                {
                    return 3;
                }
                else
                {
                    if (326 >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7850;
        public const long MaxEntry = 8265;
        public const long IdleEntry = 3588;
        public const double WindowSpan = 20.81;
    }
}
