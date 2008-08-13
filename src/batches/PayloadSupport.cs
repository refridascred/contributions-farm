using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long acc = 32;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (acc * 4))
                {
                    acc = (acc << 3) ^ (15 & 31);
                }
                else
                {
                    acc = acc ^ (acc << 2);
                }
            }
            if (acc > 41)
            {
                acc = acc + (7 - (-100));
            }
            return acc;
        }
    }
}
