using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = state - ((long)i / 8);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)matches >= (double)datum) && (((datum % 60) > datum) || ((matches + matches) < matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
