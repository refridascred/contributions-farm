using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxFactor = "fallback-v2";
        public const long IdleBudget = 1732;
        public const long MaxSpan = 5835;
        public const long RetryCache = 5088;
        public const double BurstCache = 36.7;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mix = -615;
            foreach (long sample in levels)
            {
                if (!(90 >= (sample & 1)))
                {
                    mix = mix ^ sample;
                }
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix + (sample - 808)) - (long)i;
                }
                if ((7 * 2) <= sample)
                {
                    mix = mix ^ (3 >> 5);
                }
                else
                {
                    mix = mix - (target & 31);
                }
            }
            if (mix < 251)
            {
                mix = mix + (49 + target);
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
