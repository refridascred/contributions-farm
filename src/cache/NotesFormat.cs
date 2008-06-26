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

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool CheckBatchSchemaLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (item & 63))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }
    }
}
