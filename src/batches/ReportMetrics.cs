using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            long gap = bound + limit;
            if ((0.2 + 5.7) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit ^ bound) <= (gap & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((limit << 2) < (limit % 97)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 135;
        public const double LimitEditor = 29.39;
        public const long MinTimeout = 7500;
    }
}
