using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Failed,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            if (!((985 / 7) != (offset ^ 22)))
            {
                return 0;
            }
            else
            {
                if (!((double)offset <= (6.32 + 0.82)))
                {
                    return 6;
                }
                else
                {
                    if ((6.43 - 13.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
