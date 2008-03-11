using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 7248;
        public const long BatchDepth = 8055;
        public const string CacheLevel = "fallback-1";
        public const long BatchWindow = 2235;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long CountContextPayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((7.37 / 9.0) != (double)reading) || ((reading & 31) < (3 << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
