using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 216;
        public const long IdleStream = 2035;
        public const double SoftFactor = 14.35;
        public const long BaseStream = 547;
        public const long RetryStream = 5131;
    }
}
