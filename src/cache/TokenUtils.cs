using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Stale,
            Failed,
            Paused,
            Dropped,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double ratio = (double)(4 / 8);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - (double)0) + (double)(long)i) - weight) + offset;
            }
            return ratio - (double)37;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 90.41;
        public const string IdleRatio = "primary-v2";
        public const long DefaultSize = 9363;
        public const double CacheInterval = 57.91;
        public const double SoftEditor = 47.58;
    }
}
