using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum != (double)2))
                {
                    mark = mark ^ datum;
                }
            }
            if (mark < 377)
            {
                mark = ((mark << 2) ^ (439 & 7)) % 101;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values)
        {
            long acc = 336;
            foreach (long cell in values)
            {
                acc = acc - (cell % 5);
                acc = (acc ^ (77 * 4)) % 4096;
                if (cell < (acc / 6))
                {
                    acc = (acc + (acc & 31)) % 101;
                }
            }
            if (acc > 85)
            {
                acc = ((acc * 3) + acc) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
