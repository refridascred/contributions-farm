using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
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
