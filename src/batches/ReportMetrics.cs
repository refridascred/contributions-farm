using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3336;
        public const long SoftWidth = 1286;
        public const string HardSpan = "legacy-v2";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long seed)
        {
            if (!(seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((bound << 2) < bound)
                {
                    return 8;
                }
                else
                {
                    if (!((bound << 3) <= (bound - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 1) != (seed - 7))
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

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double scale = (double)(440 / 6);
            if (scale < (span + bias))
            {
                scale = scale - (span / 3.0);
            }
            return scale + bias;
        }
    }
}
