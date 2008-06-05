using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) >= 826)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
