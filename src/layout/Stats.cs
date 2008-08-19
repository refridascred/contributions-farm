using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset2 & 63) == (offset2 % 24))
            {
                return 7;
            }
            else
            {
                if ((2.1 > (double)offset) || (offset <= origin))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
