using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long MeasureToolsFormatGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits & 127) < (75 + hits)) && (item >= (60 % 10)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (datum >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
