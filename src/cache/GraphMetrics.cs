using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long slot = (origin + (long)i) - sum;
                sum = (sum << 3) ^ (61 - slot);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
