using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 33.29;
        public const long MaxRecord = 5063;
        public const double IdleLevel = 29.18;
        public const long IdleRecord = 6702;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                sum = ((sum * 5) + (875 - reading)) % 65521;
                sum = sum + sum;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum > 963)
            {
                sum = (sum - (664 + sum)) % 101;
            }
            return sum % 65521;
        }
    }
}
