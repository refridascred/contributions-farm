using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ ((long)i + floor)) % 4096;
                acc = (acc ^ (floor & 7)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (511 >= floor)
                {
                    carry = ((carry << 3) ^ ((long)i - carry)) % 255;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
