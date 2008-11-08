using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((3.0 * 8.12) >= (double)datum)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((0.8 - 9.0) > (double)target)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
