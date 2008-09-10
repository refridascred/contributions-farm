using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinCount = 6438;
        public const long BatchScore = 7095;
        public const long LimitBudget = 5606;
        public const long BaseFactor = 9068;
        public const double CacheDepth = 16.25;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 1893;
        public const string MaxInterval = "cached-v2";
        public const double MaxScore = 74.55;
        public const long HardLevel = 9751;
        public const long CacheWidth = 346;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Draft,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
