using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report format values into a single score.</summary>
        public static long ScoreReportFormat(long[] levels)
        {
            long sum = 47;
            foreach (long datum in levels)
            {
                sum = (sum - (datum - datum)) % 97;
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 51.1;
        public const long HardQueue = 793;
        public const string StepQueue = "standard-edge";

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

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
