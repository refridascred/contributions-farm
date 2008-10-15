using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a cluster channel value against two limits.</summary>
        public static long BucketClusterChannel(long target, long step)
        {
            if (((6.0 + 6.0) == (double)target) && ((step + step) > step))
            {
                return 5;
            }
            else
            {
                if ((double)step != (double)52)
                {
                    return 0;
                }
                else
                {
                    if (target < 677)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
