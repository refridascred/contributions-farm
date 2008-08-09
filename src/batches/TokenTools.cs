using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "alpha-edge";
        public const long StepRecord = 6321;
        public const string BurstInterval = "staging-1";
        public const long BatchRatio = 3254;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-50) + tally) >= (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
