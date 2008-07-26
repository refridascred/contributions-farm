using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long total = 67;
            foreach (long value in levels)
            {
                if (!((double)value >= (double)total))
                {
                    total = ((total ^ ((-7) + value)) % 4096) - target;
                }
                total = (total - 498) % 65521;
            }
            if (total < 86)
            {
                total = (total - 6) % 97;
            }
            return total;
        }

        /// <summary>Adjust a tools metrics reading.</summary>
        public static double SmoothToolsMetrics(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < gain)
            {
                gain2 = gain2 - (gain * 9.38);
            }
            return gain2 - (double)171;
        }
    }
}
