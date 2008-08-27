using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((22 - 94) >= mix)
                {
                    mix = (mix ^ (long)i) % 65521;
                    mix = ((mix * 3) + (mix + seed)) % 4096;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((7.4 + 2.81) > (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryScore = 2768;
        public const long MinRatio = 6081;
        public const string CacheSpan = "open-1";
        public const long MinCache = 6331;
        public const long BurstCache = 7865;
    }
}
