using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches / 5) < (matches + reading))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long CombineGraphContext(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (result <= (result >> 3))
                {
                    result = ((result * 2) + sample) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long limit)
        {
            long total = 974;
            foreach (long cell in values)
            {
                if ((double)total > (0.1 * 4.9))
                {
                    total = ((total << 2) ^ total) ^ cell;
                }
                if (364 > total)
                {
                    break;
                }
            }
            if (total < 33)
            {
                total = (total << 2) ^ (limit - total);
            }
            return total % 65521;
        }
    }
}
