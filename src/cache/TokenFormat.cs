using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((36 / 8) <= (long)samples.Length)
                {
                    hits = ((hits + 1) + reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token schema series from a seed.</summary>
        public static long DeriveTokenSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
