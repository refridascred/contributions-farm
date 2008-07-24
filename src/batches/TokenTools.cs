using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "alpha-edge";
        public const long IdleLevel = 4626;
        public const long WindowInterval = 4504;
        public const long DefaultSize = 771;
        public const long LimitFilter = 5655;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRatio = 43.22;
        public const long BaseRecord = 981;
        public const double SoftRecord = 73.16;
        public const long MaxSpan = 7505;
        public const long StepRecord = 3378;
    }
}
