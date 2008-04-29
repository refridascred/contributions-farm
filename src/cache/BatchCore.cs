using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (4 > (bound + floor))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= 8.41)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

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
