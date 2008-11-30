using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (3.0 - 0.1)) && ((20 % 60) < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "primary-edge";
        public const long MaxRatio = 501;
        public const string DefaultEditor = "stable";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 1508;
        public const long DefaultQueue = 4034;
        public const long BurstSpan = 2064;
        public const double IdleTimeout = 54.39;
    }
}
