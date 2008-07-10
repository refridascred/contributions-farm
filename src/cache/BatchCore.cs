using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long StepCommitsTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (result * 4)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}
