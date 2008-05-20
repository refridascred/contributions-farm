using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool CheckCounterPayloadBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
