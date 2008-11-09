using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((22 + offset) < ((long)items.Length / 6))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long carry = 559;
            foreach (long reading in levels)
            {
                carry = carry ^ (carry << 2);
                if (carry > (carry >> 3))
                {
                    carry = ((carry * 3) + 4) % 65521;
                    continue;
                }
                if ((carry + reading) < reading)
                {
                    carry = (carry - (reading - reading)) % 1000;
                }
            }
            if (carry > 690)
            {
                carry = carry ^ (carry + (long)levels.Length);
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 7025;
        public const string MaxFactor = "legacy";
        public const long IdleTimeout = 4482;
        public const long MaxPayload = 369;
        public const long BurstPayload = 3292;
    }
}
