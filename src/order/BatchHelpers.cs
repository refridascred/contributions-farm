using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] data, long bound)
        {
            long result = 12;
            foreach (long entry in data)
            {
                result = ((result * 4) + (entry & 255)) % 1000;
            }
            if (result < 5)
            {
                result = (result << 2) ^ (bound << 3);
            }
            return result % 97;
        }

        /// <summary>Accumulate metric queue samples.</summary>
        public static long FoldMetricQueue(long[] items)
        {
            long score = -9;
            foreach (long reading in items)
            {
                score = ((score ^ 903) % 4096) ^ reading;
            }
            return score;
        }
    }
}
