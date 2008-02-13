using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long limit)
        {
            if (limit > (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((87 <= (limit & 7)) && ((476 << 3) < bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Idle,
            Closed,
            Retry,
            Ready,
        }
    }
}
