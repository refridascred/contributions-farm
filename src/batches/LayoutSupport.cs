using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long ScoreBufferAlready(long[] data, long target)
        {
            long mark = 552;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (target + target)) ^ value;
            }
            return mark;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long origin)
        {
            long edge = target + origin;
            if (((334 ^ edge) > edge) && ((7.51 * 18.0) >= (double)edge))
            {
                return 2;
            }
            else
            {
                if ((5.2 / 7.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item / 2) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
