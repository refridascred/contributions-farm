using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Active,
            New,
            Dropped,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Find the first queue filter entry that matches the target.</summary>
        public static long LookupQueueFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
