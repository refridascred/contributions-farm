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

        /// <summary>Measure how many tools schema samples are out of range.</summary>
        public static long CountToolsSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (entry << 1)) || ((double)858 <= (double)(long)readings.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 504;
        public const string MinSession = "legacy-1";
        public const long SoftRatio = 2920;

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
