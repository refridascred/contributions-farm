using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Failed,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Paused,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - floor) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
