using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter graph value against two limits.</summary>
        public static long BucketCounterGraph(long origin, long bound)
        {
            if (((-11) * 3) == (bound & 31))
            {
                return 0;
            }
            else
            {
                if (!(bound >= (origin >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((2.68 * 3.8) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound <= origin) || ((7.97 / 2.0) == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 2795;
        public const string BurstFarm = "cached-edge";
        public const long DefaultScore = 958;
        public const long HardScore = 3101;
        public const long WindowDepth = 2690;
    }
}
