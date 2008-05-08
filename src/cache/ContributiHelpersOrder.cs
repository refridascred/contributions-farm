using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BurstSize = 16.86;
        public const string HardRoute = "fallback-edge";
        public const long DefaultCount = 6862;
        public const string WindowWidth = "strict-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                carry = (carry << 3) ^ (sample << 2);
            }
            return carry % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            New,
            Dropped,
            Failed,
            Paused,
        }
    }
}
