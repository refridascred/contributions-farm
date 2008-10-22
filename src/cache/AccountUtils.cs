using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next editor order value.</summary>
        public static double ScaleEditorOrder(double gain, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (gain - 1.4)) + (double)(long)i;
            }
            return mean - 0.79;
        }

        /// <summary>Fold a list of layout account readings.</summary>
        public static long CombineLayoutAccount(long[] values)
        {
            long state = 563;
            foreach (long item in values)
            {
                if ((item ^ item) < (70 - (long)values.Length))
                {
                    state = (state ^ state) % 4096;
                }
            }
            return state;
        }
    }
}
