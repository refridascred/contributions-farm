using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (target + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool CheckFormatPayloadRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
