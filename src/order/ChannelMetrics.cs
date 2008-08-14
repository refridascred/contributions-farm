using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxInterval = "local-1";
        public const long MaxLevel = 5860;
        public const string RetryGraph = "alpha-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2943;
        public const double MinRatio = 68.75;
        public const long HardBatch = 3081;
        public const string MaxBatch = "standard-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long datum in data)
            {
                if ((1.9 / 2.0) > (double)datum)
                {
                    anchor = ((anchor ^ (datum * 2)) % 97) + offset;
                }
            }
            if (anchor > 21)
            {
                anchor = (anchor - (anchor ^ 3)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
