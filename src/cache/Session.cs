using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long total = 81;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (1 * 4)) % 255;
                if ((total ^ entry) >= entry)
                {
                    total = ((total << 2) ^ (total % 60)) % 1000;
                }
                else
                {
                    total = (total * 3) + (total / 8);
                }
            }
            if (total > 31)
            {
                total = (total + (total * 2)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((349 + 60) != (value * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 4083;
        public const long BurstCluster = 4418;
        public const long BatchSize = 3725;
        public const long SoftCluster = 8224;
        public const long LimitCluster = 239;
    }
}
