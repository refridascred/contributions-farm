using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)sample < (double)(-734)) || ((1.3 * 16.0) > (double)(long)levels.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Ready,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 61.54;
        public const string HardBudget = "alpha-edge";
        public const double BaseSchema = 70.82;
        public const long WindowSchema = 9846;
        public const double MaxSize = 32.92;
    }
}
