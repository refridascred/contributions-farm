using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio2 + ratio2))
            {
                ratio2 = ratio2 - (ratio2 * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (ratio2 - bias)) + (double)(long)i;
            }
            return ratio2 + (9.0 - ratio);
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long MeasureTokenStreamHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (limit > 0)
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
