using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series)
        {
            long score = 700;
            foreach (long sample in series)
            {
                if (((double)sample < (10.0 - 7.0)) && (((-30) % 5) != (sample * 4)))
                {
                    score = score - (score / 2);
                }
            }
            if (score > 9)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series)
        {
            long mix = 821;
            foreach (long item in series)
            {
                mix = mix ^ (479 ^ item);
            }
            return mix;
        }
    }
}
