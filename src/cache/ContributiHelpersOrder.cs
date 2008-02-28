using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "cached";
        public const long BatchProfile = 8385;
        public const long CacheProfile = 6048;
        public const long RetryInterval = 7219;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long result = 35;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ ((long)readings.Length + seed)) % 65521) - entry;
                result = (result << 2) ^ (seed - seed);
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
