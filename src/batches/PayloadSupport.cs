using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound + bound) <= 577)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (double)offset) || (bound2 >= offset))
                {
                    return 2;
                }
                else
                {
                    if (!((4.4 + 1.82) >= (double)bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
