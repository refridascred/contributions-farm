using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "stable-1";
        public const long RetryInterval = 2941;
        public const long IdleWidth = 8657;
    }
}
