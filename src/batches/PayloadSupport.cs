using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            if ((limit + origin) == (limit * 3))
            {
                return 5;
            }
            else
            {
                if ((double)6 > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (319 < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const string SoftWidth = "stable-v2";
        public const long BasePayload = 8816;
        public const string BaseWidth = "alpha-1";
    }
}
