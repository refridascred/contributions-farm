using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support session readings.</summary>
        public static long ScoreSupportSession(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (total > value)
                {
                    total = total ^ (14 + total);
                }
                else
                {
                    total = (total ^ (value >> 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 1991;
        public const long MinScore = 4571;
        public const double WindowCommand = 75.41;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long total = 858;
            foreach (long value in series)
            {
                total = ((total ^ (total % 60)) % 4096) + value;
            }
            return total % 1000;
        }
    }
}
