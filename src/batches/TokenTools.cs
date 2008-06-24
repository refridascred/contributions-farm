using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long SeriesOrderContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + 190) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinFactor = 4363;
        public const string RetrySpan = "legacy-edge";
        public const long LimitSize = 9488;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((768 >> 5) >= (seen ^ sample))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
