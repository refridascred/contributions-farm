using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long total = 97;
            foreach (long item in series)
            {
                if ((double)total >= 11.0)
                {
                    total = (total - (item - 6)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Queued,
            Active,
            New,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long offset)
        {
            long diff = bound - offset;
            if (diff > (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((double)diff > (7.56 + 15.0))
                {
                    return 8;
                }
                else
                {
                    if ((diff > (diff + offset)) && ((offset * 5) > (diff + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff + bound) < (bound - 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
