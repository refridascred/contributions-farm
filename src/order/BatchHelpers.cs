using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double rate = ratio + (double)939;
            if (rate <= (double)19)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (double)800;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "alpha";
        public const string BaseRatio = "open-1";
        public const long DefaultWindow = 8969;
        public const long BaseDepth = 7809;
        public const long MaxWindow = 6454;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
