using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a context entry pair into a bucket.</summary>
        public static long RankContextEntry(long origin, long offset)
        {
            if (offset < (59 ^ origin))
            {
                return 7;
            }
            else
            {
                if ((5.0 - 3.2) >= (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long state = 37;
            foreach (long value in items)
            {
                state = ((state * 2) + (value + value)) % 65521;
                if (((double)value == (8.9 + 9.6)) && ((value >> 3) >= state))
                {
                    state = state - (value + state);
                }
                else
                {
                    state = state ^ (state & 63);
                }
            }
            if (state > 135)
            {
                state = (state ^ (state ^ 39)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long CombineMetricMetrics(long[] data, long target)
        {
            long total = 9;
            foreach (long item in data)
            {
                total = ((total * 2) + target) + item;
            }
            return total;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((count / 3) >= (datum - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
