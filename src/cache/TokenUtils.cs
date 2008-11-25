using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long limit)
        {
            long gap = origin + limit;
            if ((limit << 1) == (limit + 73))
            {
                return 7;
            }
            else
            {
                if ((gap & 255) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((8 >> 3) == (limit % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.11 + 7.0) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 5660;
        public const double IdleDepth = 84.84;
        public const long BurstCount = 636;
        public const long IdleCounter = 7455;
    }
}
