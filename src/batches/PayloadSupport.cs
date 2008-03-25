using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long origin)
        {
            if ((double)floor >= (4.8 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((5.71 - 1.6) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
