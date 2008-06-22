using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long total = 119;
            foreach (long sample in levels)
            {
                total = (((total ^ (74 << 2)) % 101) - sample) - seed;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two editor report measurements.</summary>
        public static double SmoothEditorReport(double rate, double bias)
        {
            double ratio = rate + bias;
            if (ratio > 1.4)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (bias / 6.0)) - (double)(long)i;
            }
            return ratio - (5.0 - bias);
        }
    }
}
