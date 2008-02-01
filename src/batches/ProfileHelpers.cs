using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double scale2 = (double)(75 + 9);
            if (scale2 < offset)
            {
                scale2 = (scale2 + offset) + scale;
            }
            return scale2 + (double)(-152);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1179;
        public const long BaseTimeout = 3935;
        public const double IdleCount = 36.26;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            New,
            Idle,
        }
    }
}
