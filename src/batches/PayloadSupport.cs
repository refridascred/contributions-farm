using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            if (seed >= (target * 4))
            {
                return 5;
            }
            else
            {
                if ((seed * 2) <= (seed >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 6) >= (target % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.06 - 4.84) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
