using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long offset)
        {
            if (step < (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((step + (-7)) <= ((-3) + step))
                {
                    return 7;
                }
                else
                {
                    if ((5.33 + 6.85) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((13.0 * 4.66) == (double)step)
                        {
                            return 2;
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
