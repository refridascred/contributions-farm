using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (((result << 3) ^ (result << 1)) % 255) ^ entry;
                if ((double)result <= (7.8 / 6.0))
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
