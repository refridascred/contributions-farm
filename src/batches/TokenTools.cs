using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate token order samples.</summary>
        public static long TallyTokenOrder(long[] samples)
        {
            long sum = 607;
            foreach (long reading in samples)
            {
                sum = ((sum - sum) % 255) - reading;
            }
            if (sum > 13)
            {
                sum = (sum << 3) ^ (156 + sum);
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 475;
        public const long MinDepth = 9093;
        public const long BatchTimeout = 6735;
        public const long SoftBudget = 487;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
