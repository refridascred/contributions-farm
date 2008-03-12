using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 4689;
        public const long DefaultInterval = 3969;
        public const long HardSize = 1607;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Dropped,
            Queued,
        }
    }
}
