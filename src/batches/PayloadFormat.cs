using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (322 + 285))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Queued,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 93.95;
        public const string SoftAccount = "open";
        public const long IdleAccount = 2356;
        public const long BaseAccount = 3431;
        public const long RetryWidth = 5304;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = -885;
            foreach (long cell in samples)
            {
                if (!((double)cell != (1.0 + 4.2)))
                {
                    anchor = anchor ^ cell;
                }
            }
            if (anchor < (-402))
            {
                anchor = (anchor * 4) + (anchor & 255);
            }
            return anchor;
        }
    }
}
