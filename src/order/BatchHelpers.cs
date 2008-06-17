using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit context filter readings against a rule.</summary>
        public static long AuditContextFilterMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits < (hits - hits)))
                {
                    hits = ((hits + 1) - sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two contributi farm measurements.</summary>
        public static double AdjustContributiFarm(double ratio, double bias)
        {
            double scale = (bias * 1.9) * 0.2;
            return (scale - (bias / 3.0)) + ratio;
        }
    }
}
