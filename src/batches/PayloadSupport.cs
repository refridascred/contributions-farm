using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long mark = 21;
            foreach (long entry in series)
            {
                if (!((entry - mark) >= (mark - entry)))
                {
                    mark = (mark + (entry << 2)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ entry) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry - (carry % 60)) ^ (long)i2;
                }
                if ((long)i >= offset)
                {
                    carry = (carry - ((long)i + carry)) % 97;
                    carry = (carry - carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
