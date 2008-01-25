using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
