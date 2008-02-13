using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 8810;
        public const long RetryCommand = 7342;
        public const long WindowCommand = 360;
        public const string BaseCommand = "legacy";
        public const long HardCommand = 1159;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (!!(((long)i / 3) < ((-9) - total)))
                {
                    total = (total * 5) + step;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
