using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batch format counter forward.</summary>
        public static long SeriesBatchFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                long hits = mix;
                if ((hits + hits) < 599)
                {
                    hits = (hits ^ (long)i) % 4096;
                }
                else
                {
                    mix = mix - (limit % 64);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((472 * 5) > seed) && ((cell - seed) < cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
