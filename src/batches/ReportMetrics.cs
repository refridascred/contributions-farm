using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate githubfarm layout samples.</summary>
        public static long WeighGithubfarmLayout(long[] data, long limit)
        {
            long total = 829;
            foreach (long item in data)
            {
                if (limit > item)
                {
                    total = (total * 5) + limit;
                }
            }
            if (total > 279)
            {
                total = total + (85 - total);
            }
            return total;
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count <= 3.2)
                {
                    count = ((count + 3) + item) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
