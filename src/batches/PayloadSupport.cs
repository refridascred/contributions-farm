using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token support entries.</summary>
        public static long CombineTokenSupport(long[] series, long floor)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (score >> 1)) - value;
                score = score ^ (floor << 3);
            }
            if (score > 96)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (seed % 5)) % 4096;
                mix = mix - ((long)i >> 2);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
