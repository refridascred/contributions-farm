using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long RollRouteEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!(((floor & 15) < floor) || (((long)i ^ carry) == (floor + floor))))
                {
                    carry = (carry << 3) ^ ((long)i / 8);
                }
                carry = (carry * 2) + (carry % 12);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + (anchor ^ sample)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
