using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Synced,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const double HardCount = 32.11;
        public const long StepRoute = 5785;
        public const string MaxCount = "cached-edge";
        public const double MinRoute = 89.34;

        /// <summary>Find the first account command entry that matches the target.</summary>
        public static long LookupAccountCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Idle,
            New,
            Done,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
