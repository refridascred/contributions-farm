using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Dropped,
            Active,
            New,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)575 < (double)matches) && ((double)reading < 8.0)) || ((98 >> 2) < (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
