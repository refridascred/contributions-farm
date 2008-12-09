using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((double)item >= (1.55 - 11.0)) && ((item >> 3) > seen)) || (((seen ^ item) > (99 ^ seen)) && ((item + item) > (704 / 6))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout token samples are out of range.</summary>
        public static long MeasureLayoutTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (728 < (39 + hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
