using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double rate = (span - 19.0) + (double)5;
            if (rate >= span)
            {
                rate = rate - (17.0 - weight);
            }
            else
            {
                rate = rate + weight;
            }
            return rate + (rate * 8.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9674;
        public const string MaxRecord = "latest-1";
        public const long MinRecord = 5010;
        public const double DefaultRecord = 31.77;
        public const long BatchDepth = 5363;

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long SoftBudget = 3886;
        public const long MinDepth = 1779;
        public const string CacheRatio = "open-edge";
        public const string CacheSize = "cached-edge";

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double weight, double floor)
        {
            double mean = floor;
            if (mean <= mean)
            {
                mean = (mean + (double)7) + weight;
            }
            else
            {
                mean = mean - (double)765;
            }
            return mean + (floor / 2.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 45.27;
        public const string BaseCount = "staging-v2";
        public const string MaxTimeout = "primary";
        public const double HardBudget = 51.8;
        public const long SoftFilter = 7609;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
