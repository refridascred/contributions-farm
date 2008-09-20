using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
