using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5011;
        public const long SoftBatch = 6292;
        public const string StepLevel = "standard-1";
        public const string WindowBatch = "fallback-1";
        public const string HardSpan = "strict-v2";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream cache measurements.</summary>
        public static double ScaleStreamCache(double rate, double span)
        {
            double mean = rate;
            if (mean < mean)
            {
                mean = (mean + rate) - span;
            }
            else
            {
                mean = mean - 9.2;
            }
            return mean - (double)659;
        }
    }
}
