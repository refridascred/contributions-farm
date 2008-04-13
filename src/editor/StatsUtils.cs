using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Combine entry tools values into a single score.</summary>
        public static long DigestEntryTools(long[] series)
        {
            long score = 68;
            foreach (long reading in series)
            {
                score = ((score << 2) ^ (reading + score)) % 255;
            }
            return score;
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long ScoreWindowStream(long[] data, long floor)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                mark = (mark + (floor ^ floor)) ^ datum;
            }
            if (mark > 306)
            {
                mark = mark - (mark >> 5);
            }
            return mark;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a booking stats.</summary>
        public sealed class BookingStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((bound + entry) > (1 << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
