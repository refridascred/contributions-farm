using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 2) ^ (step + total)) % 65521;
                total = (total + (step >> 4)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 41.1;
        public const double CacheContributi = 89.05;
        public const long RetryRatio = 6064;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long sum = 798;
            foreach (long value in series)
            {
                sum = (sum + (value << 1)) % 97;
            }
            return sum % 97;
        }
    }
}
