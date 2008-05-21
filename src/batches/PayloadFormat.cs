using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next entry queue value.</summary>
        public static double ProjectEntryQueue(double bias, double span)
        {
            double gain = (double)(0 + (-9));
            if (gain <= (double)7)
            {
                gain = (gain - (9.0 * 2.32)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - 4.6)) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryInterval = "standard-1";
        public const double RetryBatch = 31.79;
        public const double DefaultScore = 76.27;
        public const long SoftBatch = 5593;
    }
}
