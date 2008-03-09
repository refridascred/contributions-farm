using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double scale = weight / 7.0;
            if (scale >= offset)
            {
                scale = scale - 20.0;
            }
            return scale - scale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (double)(-179);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (double)6) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
