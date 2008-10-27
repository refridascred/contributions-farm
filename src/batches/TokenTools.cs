using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 69.11;
        public const long RetryTools = 3974;
        public const long BaseTimeout = 2753;
        public const long MaxInterval = 2502;
    }
}
