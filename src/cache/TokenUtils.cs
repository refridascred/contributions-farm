using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items, long bound)
        {
            long anchor = 778;
            foreach (long cell in items)
            {
                if (!((cell % 8) <= (anchor - bound)))
                {
                    anchor = (anchor ^ (cell ^ anchor)) % 97;
                }
            }
            if (anchor > 439)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double rate = (weight * 1.34) - 8.8;
            if (rate <= (double)922)
            {
                rate = rate - (19.0 - 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (weight / 3.0)) + (double)(long)i;
            }
            return rate - (offset - offset);
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
