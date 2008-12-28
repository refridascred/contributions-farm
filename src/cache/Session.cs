using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5672;
        public const string BurstMetrics = "legacy";
        public const long StepCount = 1332;
        public const long WindowWidth = 8623;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2564;
        public const double BurstFilter = 52.96;
        public const double RetryFilter = 21.72;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long floor)
        {
            if ((double)floor <= (7.29 * 5.81))
            {
                return 5;
            }
            else
            {
                if (((bound - bound) <= bound) || (4 <= (floor ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) <= (floor / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.26 - 1.0) <= (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
