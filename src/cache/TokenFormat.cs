using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long sum = 937;
            foreach (long value in values)
            {
                if ((4 - value) < value)
                {
                    sum = ((sum + (531 - sum)) % 4096) - limit;
                }
            }
            if (sum < 91)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double ratio, double span)
        {
            double weight = ratio / 8.0;
            if (weight < (4.8 / 2.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - span;
            }
            return weight - (span - span);
        }
    }
}
