using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long acc = 611;
            foreach (long reading in levels)
            {
                if ((step / 2) == (acc * 2))
                {
                    acc = acc ^ (step + reading);
                }
            }
            if (acc < 560)
            {
                acc = ((acc * 4) + (8 << 3)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 6.02;
        public const long BurstReport = 7314;
        public const string IdleReport = "latest-edge";
        public const double HardCount = 20.5;
        public const long WindowReport = 4025;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 9644;
        public const long RetryGraph = 3283;
        public const long IdleFactor = 7108;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            New,
            Queued,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "fallback-1";
        public const long BurstQueue = 685;
        public const long CacheSize = 365;
        public const long CacheRatio = 2605;
    }
}
