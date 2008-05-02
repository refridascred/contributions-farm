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

        /// <summary>Derive the next account batch value from a seed.</summary>
        public static long SeriesAccountBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                long span = offset;
                if (!((offset * 4) != (span * 3)))
                {
                    anchor = (anchor << 3) ^ (anchor - 53);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
