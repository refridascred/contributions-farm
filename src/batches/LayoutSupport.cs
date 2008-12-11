using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long state = 28;
            foreach (long value in items)
            {
                if (!(state < (target * 5)))
                {
                    state = (state - (state + state)) ^ value;
                }
            }
            if (state < 988)
            {
                state = (state + target) % 101;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target < (target & 31)) || ((matches - matches) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Dropped,
            Ready,
            Paused,
            New,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ (anchor * 3);
                if (!!((anchor + bound) <= (bound + 7)))
                {
                    anchor = anchor + anchor;
                    anchor = (anchor - (long)i) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
