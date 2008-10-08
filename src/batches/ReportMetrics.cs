using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (mix - mix)) % 255;
                mix = mix ^ ((long)i & 15);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long origin)
        {
            if ((seed << 3) > origin)
            {
                return 5;
            }
            else
            {
                if ((seed * 2) != (seed * 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin - seed) == (282 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload token readings.</summary>
        public static long PairPayloadTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
