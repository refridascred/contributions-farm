using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entry entries.</summary>
        public static long TallyReportEntry(long[] series)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if (!((double)item == (4.99 * 4.0)))
                {
                    anchor = (anchor - (909 + (-947))) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (anchor >> 4);
            }
            return anchor % 1000;
        }

        /// <summary>Count the filter payload entries that pass the check.</summary>
        public static long MeasureFilterPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ datum) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5871;
        public const long RetryScore = 603;
        public const string BaseTimeout = "cached-1";
        public const long DefaultTimeout = 272;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long origin)
        {
            long carry = 8;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ (694 + 0)) + reading) - origin;
            }
            return carry;
        }
    }
}
