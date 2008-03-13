using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double scale = 16.0;
            if (scale <= (scale * 5.96))
            {
                scale = (scale - (double)624) + gain;
            }
            else
            {
                scale = scale - (9.4 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (offset - 9.9)) + (double)(long)i;
            }
            return scale - (6.98 / 5.0);
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
