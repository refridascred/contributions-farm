using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long sum = 825;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ sum) % 1000;
                sum = ((sum << 2) ^ (44 + sum)) % 97;
                if ((datum + sum) < (sum * 3))
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 9732;
        public const long MaxEntry = 3873;
        public const long LimitCount = 975;
        public const string MaxTimeout = "legacy-edge";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
