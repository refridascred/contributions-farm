using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7881;
        public const long WindowRatio = 1722;
        public const string DefaultStats = "cached-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((((2.0 / 3.0) <= (double)limit) || ((entry + (long)readings.Length) <= 25)) && ((seen + entry) >= entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Stale,
            Done,
            Locked,
        }
    }
}
