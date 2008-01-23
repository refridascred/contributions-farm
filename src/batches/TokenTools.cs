using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - 92) != (hits + (-857)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
