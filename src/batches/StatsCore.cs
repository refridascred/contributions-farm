using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a command filter reading.</summary>
        public static double SmoothCommandFilter(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (scale - scale2))
            {
                scale2 = scale2 - floor;
            }
            return scale2 + floor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long anchor = 756;
            foreach (long item in samples)
            {
                if ((item - seed) >= (seed + anchor))
                {
                    anchor = (anchor << 3) ^ (item + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (item ^ seed);
                }
                anchor = anchor - 8;
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-797) ^ item) < item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinSpan = 55.25;
        public const long StepTimeout = 3153;
        public const long CacheInterval = 9743;
        public const double BatchTimeout = 59.49;

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 59.22;
        public const long WindowEntry = 2560;
        public const long IdleEntry = 908;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
