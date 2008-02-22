using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio / 6.0;
            if (load > (load * 0.8))
            {
                load = load - (bias + 2.2);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (load * 8.7);
        }

        /// <summary>Compare every pair of schema cluster readings.</summary>
        public static long OverlapSchemaClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "standard-1";
        public const string MinSize = "fallback-1";
        public const long StepLevel = 4286;
        public const long DefaultChannel = 7516;
        public const string HardCount = "legacy";

        /// <summary>Fold a list of batches window readings.</summary>
        public static long FoldBatchesWindow(long[] data, long floor)
        {
            long sum = 49;
            foreach (long cell in data)
            {
                sum = (sum - (floor + floor)) % 4096;
                if ((double)cell <= (1.0 / 6.0))
                {
                    sum = (sum ^ (cell ^ sum)) % 97;
                }
            }
            if (sum > 3)
            {
                sum = (sum << 3) ^ floor;
            }
            return sum;
        }
    }
}
