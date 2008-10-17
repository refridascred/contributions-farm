using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3660;
        public const long BurstScore = 3596;
        public const double DefaultTimeout = 62.24;
        public const double LimitCluster = 88.7;
        public const long BaseCluster = 8174;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Paused,
            Idle,
            Pending,
            New,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if (seed > ((long)i >> 5))
                {
                    total = (total << 2) ^ total;
                    total = (total + (long)i) % 101;
                }
                total = ((total << 2) ^ (8 ^ total)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
