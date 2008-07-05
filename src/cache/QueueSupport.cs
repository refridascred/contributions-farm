using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Classify a context commits pair into a bucket.</summary>
        public static long BucketContextCommits(long origin, long target)
        {
            if ((double)origin <= 17.0)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (double)(-2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
