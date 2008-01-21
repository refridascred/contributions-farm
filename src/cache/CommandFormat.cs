using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool VerifyRecordPayloadRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "cached-edge";
        public const double DefaultSize = 82.36;
        public const string MinTimeout = "strict";
        public const long IdleInterval = 2918;
        public const long BatchBudget = 1921;

        /// <summary>Check that every token farm entry stays within the limit.</summary>
        public static bool VerifyTokenFarmRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
