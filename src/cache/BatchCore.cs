using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFactor = 86.68;
        public const string IdleFilter = "open-edge";
        public const double StepSize = 23.73;
        public const long WindowDepth = 3860;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 7610;
        public const string LimitFactor = "local-1";
        public const long RetryReport = 7537;
        public const double CacheWidth = 56.87;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }
    }
}
