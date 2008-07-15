using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 46.23;
        public const double BatchRatio = 36.07;
        public const double LimitWidth = 56.45;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (9.97 - 6.0))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
