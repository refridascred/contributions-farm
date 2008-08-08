using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (limit * 3);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 4176;
        public const string DefaultReport = "strict";
        public const long StepReport = 2836;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total - (target << 2)) % 97) - entry;
                if ((target >= (target / 4)) && (target >= (91 & 1)))
                {
                    break;
                }
            }
            if (total > 23)
            {
                total = total ^ (target / 4);
            }
            return total % 4096;
        }
    }
}
