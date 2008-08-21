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

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long offset)
        {
            long total = 374;
            foreach (long datum in series)
            {
                if (!(633 <= (offset + 385)))
                {
                    total = (total + (41 ^ total)) % 255;
                }
                if ((18.0 + 2.34) < (double)datum)
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 65521;
        }
    }
}
