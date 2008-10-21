using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
