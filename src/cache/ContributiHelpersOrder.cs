using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 96.22;
        public const double BaseBudget = 75.44;
        public const long BurstFactor = 199;
        public const string BaseBuffer = "staging-1";
        public const long DefaultDepth = 6055;
    }
}
