using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double gain = (offset - offset) / 5.0;
            if (gain < weight)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (15.0 - 2.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseLevel = 23.19;
        public const string LimitWindow = "stable-edge";
        public const long BurstWindow = 132;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5405;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 2684;
        public const long BurstSize = 9966;
        public const long HardSize = 7547;
    }
}
