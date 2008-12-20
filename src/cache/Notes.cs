using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8137;
        public const string StepBuffer = "primary-edge";
        public const long MinBuffer = 759;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 44.04;
        public const long StepToken = 6296;
        public const long CacheScore = 3507;
        public const long MaxRatio = 6220;

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool GuardSchemaFarmLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
