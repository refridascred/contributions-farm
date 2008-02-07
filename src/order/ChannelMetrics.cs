using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 22.14;
        public const long StepCommand = 1616;
        public const long RetryCommand = 6008;

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long FoldGraphBatches(long[] levels)
        {
            long sum = -747;
            foreach (long value in levels)
            {
                sum = (((sum * 3) + (sum << 3)) % 65521) + value;
            }
            return sum % 4096;
        }

        /// <summary>Combine token batches values into a single score.</summary>
        public static long ScoreTokenBatches(long[] readings, long target)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                mark = (mark * 2) + (cell + cell);
                mark = mark + cell;
            }
            if (mark < 37)
            {
                mark = ((mark * 2) + (target + target)) % 65521;
            }
            return mark % 65521;
        }
    }
}
