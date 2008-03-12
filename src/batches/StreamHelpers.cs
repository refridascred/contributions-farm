using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (4 > (sample ^ matches))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Draft,
            Failed,
        }
    }
}
