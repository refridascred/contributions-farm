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

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowWidth = 8.33;
        public const long SoftDepth = 6601;
        public const double DefaultRoute = 70.88;
        public const double BaseDepth = 65.92;
        public const string SoftRoute = "staging-1";
    }
}
