using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Synced,
            New,
            Stale,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values, long target)
        {
            long mark = 101;
            foreach (long reading in values)
            {
                mark = ((mark - (target / 4)) % 65521) ^ reading;
            }
            if (mark < 7)
            {
                mark = (mark + (target + target)) % 65521;
            }
            return mark % 4096;
        }
    }
}
