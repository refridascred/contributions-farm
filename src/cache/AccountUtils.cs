using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long target)
        {
            if ((target ^ target) <= (bound + 508))
            {
                return 8;
            }
            else
            {
                if ((559 & 127) >= bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public bool Weight { get; set; }
        }
    }
}
