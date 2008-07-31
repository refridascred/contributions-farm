using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Validate format entry readings against a bound.</summary>
        public static bool ValidateFormatEntryRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                result = ((result << 3) ^ (limit ^ limit)) ^ cell;
            }
            return result % 97;
        }
    }
}
