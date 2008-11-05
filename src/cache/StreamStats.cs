using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a payload checks counter forward.</summary>
        public static long IteratePayloadChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (target < (result * 5))
                {
                    result = (result * 5) + (long)i;
                }
                else
                {
                    result = (result ^ (target / 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double bias2 = 6.8;
            if (bias2 > (5.9 / 8.0))
            {
                bias2 = (bias2 + bias) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)(-499)) + (double)(long)i;
            }
            return bias2 + (double)(-732);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
