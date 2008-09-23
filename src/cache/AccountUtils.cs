using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4129;
        public const string BatchDepth = "legacy-1";
        public const long IdleFactor = 3567;
        public const long WindowReport = 6513;

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
