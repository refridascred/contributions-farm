using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long SeekAlreadyMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "primary-v2";
        public const long WindowContributi = 2361;
        public const double MaxTimeout = 88.32;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (6.0 / 3.0))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
