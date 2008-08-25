using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (seed >= count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a counter record reading by value.</summary>
        public static long FindCounterRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleWidth = 19.07;
        public const string HardChecks = "primary-v2";
        public const long WindowScore = 1645;
    }
}
