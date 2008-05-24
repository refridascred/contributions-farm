using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (total & 255)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 4423;
        public const double IdleScore = 26.0;
        public const long BurstCommand = 6644;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Locked,
            Active,
            New,
            Done,
        }
    }
}
