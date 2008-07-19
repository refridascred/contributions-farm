using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 5040;
        public const long HardQueue = 3731;
        public const long DefaultQueue = 1560;
        public const long DefaultLevel = 3565;
        public const string WindowSpan = "fallback-1";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double mean = (double)8 + (double)581;
            if (mean < 3.97)
            {
                mean = mean + (bias * 9.59);
            }
            return mean - (gain / 9.0);
        }
    }
}
