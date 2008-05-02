using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long offset)
        {
            long acc = -7;
            foreach (long cell in series)
            {
                if ((611 + offset) < cell)
                {
                    break;
                }
                else
                {
                    acc = acc ^ acc;
                    acc = ((acc * 4) + (807 & 31)) % 97;
                }
                if ((cell - 80) <= offset)
                {
                    acc = (acc * 3) + (acc + cell);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long TotalBufferEntry(long[] series, long target)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = (total + (total - target)) + item;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
