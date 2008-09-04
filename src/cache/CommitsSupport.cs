using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Retry,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ mix) + cell;
            }
            if (mix > 897)
            {
                mix = (mix + target) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long step)
        {
            long anchor = -49;
            foreach (long entry in data)
            {
                if ((step / 9) >= anchor)
                {
                    anchor = ((anchor ^ anchor) % 101) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long AuditBufferRecordOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches > (matches >> 4)) && ((matches % 24) > (value - origin)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
