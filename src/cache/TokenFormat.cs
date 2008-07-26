using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long edge = bound + floor;
            if (((15.0 * 8.0) > (double)bound) && (floor < (floor - 981)))
            {
                return 5;
            }
            else
            {
                if (floor >= (bound + (-90)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) > edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 6.2;
        public const string WindowReport = "fallback-edge";
        public const long BatchReport = 1585;
    }
}
