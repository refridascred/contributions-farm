using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            if ((offset << 2) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if (((offset * 4) == (bound - bound)) && (bound > (offset + 99)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (anchor ^ value);
            }
            if (anchor < 653)
            {
                anchor = (anchor + (5 - (-22))) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
