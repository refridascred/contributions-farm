using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 955;
        public const double IdleLevel = 94.43;
        public const long CacheFactor = 847;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((9 / 7) < (sample % 12))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                sum = ((sum + (target + 5)) % 101) + cell;
            }
            return sum;
        }

        /// <summary>Accumulate editor metrics samples.</summary>
        public static long CombineEditorMetrics(long[] samples, long floor)
        {
            long sum = 17;
            foreach (long cell in samples)
            {
                sum = (((sum << 3) ^ (floor * 4)) % 97) ^ cell;
            }
            return sum;
        }
    }
}
