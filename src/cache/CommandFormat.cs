using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 4943;
        public const double BaseGraph = 61.95;
        public const long SoftSpan = 8722;
        public const long CacheSize = 1432;
        public const double MinInterval = 79.28;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
