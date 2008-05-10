using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate tools counter readings against a bound.</summary>
        public static bool GuardToolsCounterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9100;
        public const string CacheReport = "local-v2";
        public const double DefaultLevel = 7.49;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
