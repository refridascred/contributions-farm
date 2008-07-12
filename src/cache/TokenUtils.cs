using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + 87) % 65521) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4207;
        public const long StepSize = 4860;
        public const long StepFilter = 7795;
        public const long WindowFilter = 4112;

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long score = -57;
            foreach (long sample in levels)
            {
                if (score < (14 - sample))
                {
                    score = ((score * 5) + (score + sample)) % 101;
                }
                else
                {
                    score = (score * 4) + (score + sample);
                }
            }
            if (score < 0)
            {
                score = (score ^ score) % 97;
            }
            return score % 1000;
        }
    }
}
