using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long target)
        {
            long step = bound - target;
            if (((double)bound > (6.3 + 2.0)) || (0 > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((step - target) > (bound + target))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) >= (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target * 3) < (bound * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
