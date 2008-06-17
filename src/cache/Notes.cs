using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Queued,
            Dropped,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if (((double)bound >= (double)mark) && (cell >= (bound + bound)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark + (9 ^ 876);
                    mark = ((mark << 3) ^ (713 * 2)) % 97;
                }
                mark = mark + (bound / 7);
                if ((4.0 - 6.2) < (double)cell)
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = (mark ^ (bound - 21)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double gain = 5.0;
            if (gain >= (6.0 / 2.0))
            {
                gain = ((gain - gain) + ratio) + offset;
            }
            return gain + gain;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
