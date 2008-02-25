using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 68.31;
        public const double LimitTimeout = 34.52;
        public const long HardSchema = 608;
        public const long HardDepth = 4624;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long target)
        {
            long total = -7;
            foreach (long value in samples)
            {
                total = ((total - total) - value) - target;
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit >> 3) < sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a route checks counter forward.</summary>
        public static long IterateRouteChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix - ((long)i / 5)) % 255) ^ (long)i2;
                }
                mix = mix ^ (bound / 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
