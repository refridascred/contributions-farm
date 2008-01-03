using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((3 / 9) != (seen % 64)) || ((double)datum <= (4.38 / 8.0))) || !(((long)series.Length ^ datum) > (seen ^ 520)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 3) <= (matches + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
