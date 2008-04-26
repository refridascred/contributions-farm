using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5209;
        public const long MaxBatch = 727;
        public const long RetryBatch = 8340;

        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long BucketPayloadFarm(long offset, long target)
        {
            long step = offset ^ target;
            if ((step + target) >= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((step * 2) != (step + offset)) || ((2 + target) == (step >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((target + step) > (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((((-5) + step) <= target) && ((target << 3) >= ((-1) + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long origin)
        {
            if ((44 + seed) >= (seed << 2))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((seed - 87) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((434 * 5) >= origin) && ((seed + seed) <= (seed % 8)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
