using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Queued,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long anchor = 383;
            foreach (long reading in levels)
            {
                if ((anchor * 4) == (reading + offset))
                {
                    anchor = (anchor ^ (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 3) != (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
