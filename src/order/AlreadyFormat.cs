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

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowBudget = 7777;
        public const long IdleRoute = 9849;
        public const double StepSpan = 59.58;
        public const long HardRoute = 1621;
        public const long StepRoute = 1348;

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
