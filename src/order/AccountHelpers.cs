using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Dropped,
            Closed,
        }

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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long carry = 956;
            foreach (long cell in samples)
            {
                carry = (carry + (cell * 4)) % 65521;
                carry = (carry + ((-305) + 3)) % 97;
                if (133 < (cell * 4))
                {
                    carry = (carry * 3) + (cell & 15);
                }
            }
            return carry % 4096;
        }
    }
}
