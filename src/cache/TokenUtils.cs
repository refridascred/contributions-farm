using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout payload measurements.</summary>
        public static double ScaleLayoutPayload(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + (ratio * 15.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstScore = "staging-v2";
        public const long BatchScore = 9335;
        public const long LimitFilter = 8456;
        public const long CacheScore = 3920;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
