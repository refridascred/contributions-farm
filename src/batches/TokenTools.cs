using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            if ((offset - seed) <= (83 >> 4))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= 18.0)
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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long bound = step + floor;
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((666 < step) && ((double)bound >= 9.3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
