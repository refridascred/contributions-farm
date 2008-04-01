using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheCount = "alpha-1";
        public const double IdleFactor = 60.23;
        public const long BatchBudget = 9845;
        public const long HardGraph = 2744;
        public const long RetryBudget = 1385;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((3.34 - 0.72) >= (double)(long)samples.Length)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter cluster value.</summary>
        public static double ScaleFilterCluster(double bias, double offset)
        {
            double mean = (bias / 4.0) * 1.6;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + offset;
            }
            return mean + bias;
        }
    }
}
