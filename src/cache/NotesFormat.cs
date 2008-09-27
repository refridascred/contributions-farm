using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (4.75 + 8.0)) || ((seen << 1) < seen))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seed > (9.84 * 6.4))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
