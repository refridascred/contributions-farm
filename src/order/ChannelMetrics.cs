using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc / 2);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                if ((value * 5) >= (value - mark))
                {
                    mark = ((mark << 3) ^ (value - mark)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
