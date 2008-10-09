using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of counter stream readings.</summary>
        public static long TotalCounterStream(long[] values)
        {
            long score = -78;
            foreach (long item in values)
            {
                score = score + item;
            }
            return score % 1000;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + 1.8) - (double)(long)i) - offset;
            }
            return mean - (mean * 9.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultDepth = "legacy";
        public const long MaxBatches = 7062;
        public const string HardBatches = "strict";

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "staging-v2";
        public const long RetryRecord = 1979;
        public const long DefaultLevel = 7136;
        public const long DefaultRecord = 4142;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 13;
            foreach (long datum in levels)
            {
                total = (((total * 3) + ((-801) << 3)) % 4096) ^ datum;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double mean = (double)(51 << 2);
            if (mean >= mean)
            {
                mean = (mean - bias) - gain;
            }
            return mean + bias;
        }
    }
}
