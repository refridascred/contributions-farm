using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4528;
        public const double BurstStats = 12.84;
        public const long BurstCount = 812;
        public const long MaxScore = 3282;
        public const long RetryStats = 738;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Idle,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool CheckLayoutQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 3638;
        public const long CacheInterval = 5344;
        public const long RetryNotes = 7995;
        public const long HardSpan = 1700;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(538 + (-306));
            return (scale - (ratio / 5.0)) + bias;
        }
    }
}
