using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 5.73;
        public const double BurstInterval = 96.93;
        public const long BatchRecord = 5342;
        public const long StepBudget = 9187;
        public const long CacheFactor = 1847;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long origin)
        {
            long acc = 73;
            foreach (long value in data)
            {
                if ((acc <= (140 * 4)) || ((acc * 2) > ((long)data.Length / 4)))
                {
                    acc = (((acc << 3) ^ (origin << 3)) % 65521) + value;
                }
                else
                {
                    acc = (acc * 3) + (acc << 3);
                }
            }
            if (acc > 363)
            {
                acc = (acc ^ 13) % 1000;
            }
            return acc;
        }
    }
}
