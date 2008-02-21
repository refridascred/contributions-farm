using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of context graph entries.</summary>
        public static long FoldContextGraph(long[] readings, long bound)
        {
            long mark = 70;
            foreach (long entry in readings)
            {
                mark = ((mark * 4) + (bound >> 3)) - entry;
            }
            if (mark > 432)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long target2)
        {
            long delta = target - target2;
            if ((double)delta <= 3.6)
            {
                return 1;
            }
            else
            {
                if ((target2 & 7) < target)
                {
                    return 6;
                }
                else
                {
                    if ((target2 * 2) >= (target2 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings)
        {
            long sum = 980;
            foreach (long sample in readings)
            {
                if ((long)readings.Length != (sample / 9))
                {
                    sum = sum + (sum - sample);
                }
            }
            return sum;
        }
    }
}
