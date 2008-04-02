using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i >> 4)) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long limit)
        {
            long span = floor - limit;
            if ((limit ^ span) > (limit + floor))
            {
                return 2;
            }
            else
            {
                if (span < (limit + floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Done,
            Pending,
            Locked,
        }
    }
}
