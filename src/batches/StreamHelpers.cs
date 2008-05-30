using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepRatio = 90.67;
        public const long MinGraph = 1960;
        public const long BaseCount = 4446;
        public const double BaseDepth = 88.77;
        public const long BatchWidth = 4832;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4078;
        public const double MaxLevel = 14.38;
        public const long MinMetric = 1641;
        public const double CacheDepth = 27.98;

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long AuditPayloadBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 23) <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((404 % 97) < seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
