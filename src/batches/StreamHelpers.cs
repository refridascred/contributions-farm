using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Failed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order stats pair into a bucket.</summary>
        public static long BucketOrderStats(long floor, long floor2)
        {
            if ((floor2 + floor) < (1 / 7))
            {
                return 5;
            }
            else
            {
                if ((2.8 - 0.9) == (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Dropped,
        }
    }
}
