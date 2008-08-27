using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long step)
        {
            if (!((19.0 + 1.6) > (5.71 + 14.0)))
            {
                return 6;
            }
            else
            {
                if ((4.4 - 1.2) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((315 / 3) < (seed % 60)) && ((double)step != (2.0 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed >= (3.1 / 7.0)) || ((double)step != (5.76 / 9.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
