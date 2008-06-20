using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 1502;
        public const string LimitContributi = "open-edge";
        public const double HardSpan = 24.35;

        /// <summary>Digest a series of order payload entries.</summary>
        public static long TallyOrderPayload(long[] levels, long offset)
        {
            long carry = 55;
            foreach (long reading in levels)
            {
                carry = (((carry + carry) % 4096) - reading) - offset;
            }
            return carry % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.7 <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
