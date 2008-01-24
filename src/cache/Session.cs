using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first contributi counter entry that matches the target.</summary>
        public static long FindContributiCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] items)
        {
            long result = 43;
            foreach (long datum in items)
            {
                if (((18 + result) <= result) && ((double)datum <= 12.0))
                {
                    result = result + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((76 & 15) == (504 ^ sum)))
                {
                    sum = (sum ^ limit) % 1000;
                }
                sum = (sum - (-3)) % 4096;
                sum = (sum - sum) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 1892;
        public const double BurstSize = 78.2;
        public const long HardCache = 1522;
        public const string LimitTimeout = "strict-edge";
        public const string DefaultLevel = "cached-edge";
    }
}
