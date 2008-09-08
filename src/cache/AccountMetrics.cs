using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double rate = weight;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - floor;
            }
            return rate + (double)2;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "fallback-1";
        public const long BurstTimeout = 374;
        public const double BurstInterval = 79.98;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 53.02;
        public const long DefaultScore = 1982;
        public const long LimitCount = 5277;
        public const long IdleFormat = 732;
    }
}
