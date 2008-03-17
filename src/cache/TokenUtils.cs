using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long CountReportWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((18.0 * 8.8) != (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "primary";
        public const long WindowSupport = 7830;
        public const long LimitSupport = 4421;
        public const double HardSize = 59.83;
        public const double HardFactor = 13.79;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
