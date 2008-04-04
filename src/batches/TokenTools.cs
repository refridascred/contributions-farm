using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of order channel entries.</summary>
        public static long FoldOrderChannel(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ 41) % 65521;
                if ((reading % 5) == (reading >> 3))
                {
                    anchor = anchor ^ (reading / 2);
                }
                else
                {
                    anchor = (anchor * 2) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((origin ^ matches) != (entry / 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Dropped,
            Synced,
            Done,
            Pending,
        }
    }
}
