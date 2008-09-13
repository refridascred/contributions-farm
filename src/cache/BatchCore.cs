using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Look up the position of a tools stats sample.</summary>
        public static long SeekToolsStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "open";
        public const long RetryBudget = 250;
        public const long IdleSpan = 9503;
        public const long MinMetric = 1890;
        public const long MaxMetric = 4537;
    }
}
