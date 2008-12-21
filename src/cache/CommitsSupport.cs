using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (bound - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                long lane = mix;
                if (!((lane >> 1) > (bound & 127)))
                {
                    lane = (lane * 2) + (bound & 127);
                }
                if (((double)bound != (10.0 * 11.0)) && ((12.0 - 5.16) != (double)cell))
                {
                    mix = ((mix * 5) + (bound - bound)) % 4096;
                }
            }
            if (mix > 37)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 15.65;
        public const long MaxPayload = 5963;
        public const long SoftCount = 607;
    }
}
