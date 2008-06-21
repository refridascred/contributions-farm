using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 8564;
        public const long MinLevel = 3253;
        public const long HardInterval = 6401;
        public const long MinContributi = 3057;
        public const long MaxCount = 7131;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long MeasureRecordOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((long)samples.Length + entry) < (entry + entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Synced,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + offset) % 65521) - (long)i2;
                }
                if (((sum ^ sum) > (7 % 7)) && ((double)offset >= 7.96))
                {
                    sum = (sum - ((long)i + 824)) % 65521;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    sum = (sum + (sum % 7)) - (long)i3;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
