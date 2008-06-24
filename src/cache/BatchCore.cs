using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long FoldBatchBuffer(long[] samples, long bound)
        {
            long result = 75;
            foreach (long item in samples)
            {
                result = ((((result << 2) ^ result) % 101) + item) - bound;
                result = (result - (result * 2)) % 97;
                if ((double)result == (0.34 / 5.0))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (entry << 3)) % 1000) - limit;
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if (offset <= (offset << 1))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) <= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) <= (datum - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
