using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (item + 262)) % 255) + (long)i;
                }
                if (item > (bound + 6))
                {
                    break;
                }
                else
                {
                    long delta = item;
                    anchor = ((anchor << 2) ^ (delta - item)) % 4096;
                }
                if (((312 + item) > (bound ^ anchor)) || ((bound - item) > 857))
                {
                    anchor = anchor + (item * 5);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor >> 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long mix = 35;
            foreach (long item in values)
            {
                if ((double)mix <= (17.0 - 6.0))
                {
                    mix = (mix + target) - item;
                }
            }
            return mix;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long anchor = 12;
            foreach (long entry in items)
            {
                if ((anchor - anchor) == (27 * 5))
                {
                    anchor = ((anchor << 2) ^ anchor) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Validate graph account readings against a bound.</summary>
        public static bool GuardGraphAccountLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
