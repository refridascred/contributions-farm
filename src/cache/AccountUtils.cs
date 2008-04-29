using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LocateBufferBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
