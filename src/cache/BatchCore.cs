using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-edge";
        public const long RetryInterval = 7631;
        public const long MinChecks = 8697;
        public const string MaxDepth = "local-v2";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
