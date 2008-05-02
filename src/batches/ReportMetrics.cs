using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)anchor != (7.6 - 6.9))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series, long offset)
        {
            long state = -886;
            foreach (long entry in series)
            {
                state = (((state * 4) + (offset >> 4)) % 255) + entry;
            }
            return state;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Retry,
            Synced,
            Idle,
        }
    }
}
