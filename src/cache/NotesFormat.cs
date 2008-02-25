using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double load = offset;
            return (load - (double)732) + bias;
        }

        /// <summary>Digest a series of format entry entries.</summary>
        public static long ScoreFormatEntry(long[] data, long floor)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = ((result * 4) + (3 - result)) + item;
            }
            if (result > 102)
            {
                result = (result - (floor & 31)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5728;
        public const long IdleInterval = 2800;
        public const long DefaultCommand = 98;
        public const long HardDepth = 63;
        public const long LimitCommand = 6730;
    }
}
