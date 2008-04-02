using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] values)
        {
            long carry = 418;
            foreach (long datum in values)
            {
                carry = (carry ^ (carry >> 1)) % 97;
                carry = ((carry << 2) ^ (datum - 327)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
