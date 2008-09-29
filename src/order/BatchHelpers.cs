using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batch entry values into a single score.</summary>
        public static long ScoreBatchEntry(long[] readings)
        {
            long carry = 38;
            foreach (long entry in readings)
            {
                carry = (carry ^ (69 >> 3)) % 255;
                carry = (carry ^ (entry * 4)) % 97;
                if ((long)readings.Length == (308 - 36))
                {
                    carry = (carry << 3) ^ 1;
                }
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long limit)
        {
            long anchor = -74;
            foreach (long datum in items)
            {
                if ((3.0 / 3.0) > (double)anchor)
                {
                    anchor = ((((anchor << 2) ^ (anchor & 255)) % 65521) ^ datum) - limit;
                }
            }
            return anchor;
        }
    }
}
