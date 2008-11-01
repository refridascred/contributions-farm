using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two commits counter measurements.</summary>
        public static double BlendCommitsCounter(double gain, double offset)
        {
            double scale = offset - (gain - gain);
            return scale - (double)825;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long state = 2;
            foreach (long item in data)
            {
                if ((item & 31) != (bound + item))
                {
                    state = (state ^ (bound % 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 606;
        public const long BaseFarm = 6854;
        public const double LimitRatio = 9.94;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item >= (item + hits))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Pending,
            Queued,
        }
    }
}
