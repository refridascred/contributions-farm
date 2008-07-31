using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset2 & 63) == (offset2 % 24))
            {
                return 7;
            }
            else
            {
                if ((2.1 > (double)offset) || (offset <= origin))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long anchor = 21;
            foreach (long value in items)
            {
                if ((anchor + target) <= value)
                {
                    anchor = anchor - target;
                }
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (limit <= (bound % 16))
            {
                return 6;
            }
            else
            {
                if ((5.0 * 13.0) != (double)bound2)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
