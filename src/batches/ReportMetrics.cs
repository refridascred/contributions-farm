using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 82;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + datum) % 97) - (long)i;
                }
                score = (score - (long)series.Length) % 255;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "cached-v2";
        public const double WindowSize = 15.04;
        public const long RetryCounter = 9963;
        public const double RetrySize = 85.85;
    }
}
