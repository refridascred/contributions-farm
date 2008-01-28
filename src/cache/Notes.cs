using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 79.73;
        public const double SoftChannel = 3.31;
        public const long DefaultChannel = 7778;
        public const long MaxRatio = 1572;
        public const long SoftWidth = 8928;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 6337;
        public const string RetryFactor = "open-1";
        public const long MinWidth = 8979;
        public const long HardBuffer = 3954;
        public const long BaseBuffer = 9563;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Paused,
            Dropped,
            Stale,
            Pending,
        }
    }
}
