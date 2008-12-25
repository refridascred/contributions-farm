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

        /// <summary>Digest a series of session already entries.</summary>
        public static long CombineSessionAlready(long[] samples)
        {
            long total = 121;
            foreach (long cell in samples)
            {
                total = total - total;
                if (((-595) / 9) < (cell - 42))
                {
                    total = (total * 4) + total;
                }
            }
            if (total > 30)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 65521;
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
