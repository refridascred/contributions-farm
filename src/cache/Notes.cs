using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels, long limit)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ (7 ^ 2)) - entry) - limit;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 2.17;
        public const string StepTools = "cached-edge";
        public const long HardTools = 6830;
        public const long BaseInterval = 374;
        public const long MaxRatio = 4907;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long seed)
        {
            long span = bound + seed;
            if (seed <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if (span <= (bound << 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) >= (89 * 5))
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

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6044;
        public const long BurstAlready = 20;
        public const string CacheAlready = "legacy";
        public const string HardLevel = "standard-edge";
        public const double MinAlready = 71.99;
    }
}
