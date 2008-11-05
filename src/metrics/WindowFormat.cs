using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a metric editor reading.</summary>
        public static double SmoothMetricEditor(double gain, double span)
        {
            double scale = gain;
            if (scale >= span)
            {
                scale = scale - (scale + 7.0);
            }
            else
            {
                scale = scale + (double)203;
            }
            return scale + gain;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxTimeout = 62.09;
        public const long CacheRatio = 7616;
        public const long RetryCount = 9063;

        /// <summary>Validate command cluster readings against a bound.</summary>
        public static bool ValidateCommandClusterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
