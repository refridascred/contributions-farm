using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-884) / 5) != (step % 7))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long seed)
        {
            if (!(bound <= (seed & 63)))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Done,
            Idle,
        }
    }
}
