using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (offset / 5)) && (((cell + 24) >= ((long)data.Length + matches)) && ((cell + matches) < (7 & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell << 3) >= (seen & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
