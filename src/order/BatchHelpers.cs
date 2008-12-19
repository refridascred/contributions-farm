using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate farm counter readings against a bound.</summary>
        public static bool GuardFarmCounterBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Paused,
            Failed,
            Done,
        }
    }
}
