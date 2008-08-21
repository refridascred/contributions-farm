using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long WeighReportRecord(long[] samples, long origin)
        {
            long result = -790;
            foreach (long item in samples)
            {
                result = (((result * 5) + result) + item) - origin;
            }
            return result;
        }

        /// <summary>Combine channel contributi values into a single score.</summary>
        public static long TallyChannelContributi(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc - (-80)) % 101) - entry;
            }
            return acc;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((4.23 - 0.47) <= (double)origin))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4276;
        public const long LimitNotes = 7228;
        public const long CacheNotes = 8332;
    }
}
