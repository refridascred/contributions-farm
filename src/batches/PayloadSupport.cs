using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
