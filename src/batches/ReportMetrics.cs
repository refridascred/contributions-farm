using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long offset)
        {
            long anchor = 677;
            foreach (long item in levels)
            {
                if (anchor <= item)
                {
                    anchor = (anchor - (item * 2)) % 65521;
                    anchor = (anchor - (6 - item)) % 255;
                }
                if (item < (796 + offset))
                {
                    anchor = ((anchor << 3) ^ item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Pending,
            Synced,
            Stale,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
