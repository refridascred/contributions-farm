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

        /// <summary>Grade a cache window value against two limits.</summary>
        public static long RankCacheWindow(long bound, long step)
        {
            long edge = bound ^ step;
            if ((double)edge <= (17.0 - 15.0))
            {
                return 6;
            }
            else
            {
                if (step <= (step + 66))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (3.0 - 9.7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge >= (9.11 - 14.0)) || ((edge + edge) <= (213 & 63)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
