using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long seed)
        {
            if ((double)limit >= (11.0 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
