using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (bound & 15)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
