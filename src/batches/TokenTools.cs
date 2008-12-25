using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + 160) == (acc & 31))
                {
                    acc = acc + (acc & 7);
                    acc = (acc - (acc / 3)) % 65521;
                }
                acc = (acc + ((long)i - offset)) % 65521;
                if ((double)(long)i != (8.2 + 3.11))
                {
                    acc = acc - (acc - acc);
                }
                else
                {
                    acc = (acc * 4) + (offset * 2);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long acc = -4;
            foreach (long cell in series)
            {
                acc = ((acc ^ (717 - acc)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
