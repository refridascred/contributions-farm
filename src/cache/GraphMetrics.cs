using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double scale = (double)30 - (bias - offset);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many already buffer samples are out of range.</summary>
        public static long MeasureAlreadyBufferOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading << 3) >= matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
