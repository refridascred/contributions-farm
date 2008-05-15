using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics context samples.</summary>
        public static long FoldMetricsContext(long[] values, long target)
        {
            long state = 10;
            foreach (long entry in values)
            {
                if ((entry >> 2) >= state)
                {
                    state = ((state * 4) + (entry + target)) % 101;
                }
                state = (state - (target + state)) % 255;
            }
            if (state > 9)
            {
                state = (state - (target / 8)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((seed + seed) < (339 % 97))
            {
                return 4;
            }
            else
            {
                if (cur <= (659 + seed))
                {
                    return 7;
                }
                else
                {
                    if ((5.7 * 9.41) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            New,
            Stale,
        }
    }
}
