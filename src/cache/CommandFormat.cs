using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9630;
        public const long BatchSize = 8816;
        public const double StepCount = 76.57;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 545;
        public const long SoftFarm = 8135;
        public const long BurstFactor = 8001;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            long prev = offset + bound;
            if (bound >= (offset << 3))
            {
                return 8;
            }
            else
            {
                if ((offset ^ prev) < (88 & 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
