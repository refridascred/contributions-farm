using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes channel values into a single score.</summary>
        public static long FoldNotesChannel(long[] values)
        {
            long anchor = 411;
            foreach (long reading in values)
            {
                if ((anchor + anchor) >= (anchor - reading))
                {
                    anchor = (anchor - reading) % 4096;
                }
                anchor = anchor ^ ((-3) - reading);
            }
            if (anchor > 63)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen & 31) >= seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}
