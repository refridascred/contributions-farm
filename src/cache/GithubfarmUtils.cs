using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long BucketCommitsWindow(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((next - next) != (278 >> 5))
            {
                return 5;
            }
            else
            {
                if ((next & 31) < (next + floor))
                {
                    return 2;
                }
                else
                {
                    if ((1.48 / 4.0) <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
