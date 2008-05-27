using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 525;
        public const string BurstDepth = "open";
        public const long MinCommand = 3234;
        public const string IdleCommand = "open-1";
        public const long RetryDepth = 6046;

        /// <summary>Rank buffer order input into a small class.</summary>
        public static long ClassifyBufferOrder(long limit, long origin)
        {
            if ((origin >> 1) < limit)
            {
                return 8;
            }
            else
            {
                if ((9 - 2) == (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
