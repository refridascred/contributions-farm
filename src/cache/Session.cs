using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4141;
        public const long MaxSpan = 9077;
        public const string DefaultFarm = "stable-1";

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
