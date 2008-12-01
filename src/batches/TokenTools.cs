using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleScore = "stable-1";
        public const string BatchRoute = "strict-v2";
        public const double CacheBudget = 86.68;
        public const long BurstRoute = 6659;

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long DeriveGraphCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (sum + sum)) - (long)i2;
                }
                if (((-860) + step) >= (step + 39))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxWidth = "latest-edge";
        public const long MaxDepth = 7658;
        public const double BaseSize = 63.97;
        public const double RetryRatio = 35.91;
    }
}
