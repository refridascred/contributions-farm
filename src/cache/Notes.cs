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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (6.3 / 9.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
