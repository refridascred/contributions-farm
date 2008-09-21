using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate schema context readings against a bound.</summary>
        public static bool CheckSchemaContextBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
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
