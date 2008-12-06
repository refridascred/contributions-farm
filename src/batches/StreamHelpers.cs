using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Failed,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 6099;
        public const long MinCommand = 5825;
        public const long CacheWidth = 7016;
        public const long MinWidth = 3018;
        public const long BurstCommand = 2866;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long TallyMetricsCommits(long[] readings)
        {
            long result = -969;
            foreach (long reading in readings)
            {
                if ((4.0 - 6.24) != (double)result)
                {
                    result = ((result << 2) ^ (reading ^ reading)) % 255;
                }
            }
            if (result < 339)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheLevel = 293;
        public const long IdleBudget = 969;
        public const double HardBudget = 89.87;
        public const string IdleFilter = "latest-edge";
    }
}
