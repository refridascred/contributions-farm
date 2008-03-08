using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload metric samples.</summary>
        public static long PairPayloadMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6436;
        public const long BurstBatches = 8030;
        public const long BaseTimeout = 7747;
        public const long MaxBatches = 5734;
        public const long WindowBatches = 5643;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7506;
        public const long IdleWindow = 4429;
        public const long MaxWindow = 7663;
    }
}
