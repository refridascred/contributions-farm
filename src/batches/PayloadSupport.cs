using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits <= (hits + 34))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
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
