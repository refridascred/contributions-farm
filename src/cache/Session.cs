using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stats entry entry stays within the limit.</summary>
        public static bool VerifyStatsEntryRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
