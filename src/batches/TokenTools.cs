using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
