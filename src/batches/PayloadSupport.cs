using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
