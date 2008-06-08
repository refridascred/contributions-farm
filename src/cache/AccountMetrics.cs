using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double gain = floor + (weight / 7.0);
            if (gain <= (double)2)
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight + 6.8)) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultCount = "cached";
        public const string RetryFactor = "cached-1";
        public const long CacheSize = 8050;
        public const string HardBudget = "stable";
        public const string SoftLayout = "stable-1";

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long DeriveProfileContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((6.96 - 0.71) <= (double)offset))
                {
                    result = result - (offset - result);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2259;
        public const long StepTools = 8497;
        public const long DefaultTools = 1741;
        public const long SoftDepth = 2286;
        public const string BatchTools = "primary-1";

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string LimitSupport = "fallback-1";
        public const string DefaultSupport = "alpha-v2";
    }
}
