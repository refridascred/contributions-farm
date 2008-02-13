using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine filter counter values into a single score.</summary>
        public static long TotalFilterCounter(long[] levels, long target)
        {
            long state = 522;
            foreach (long cell in levels)
            {
                state = ((state << 3) ^ (cell % 8)) + target;
            }
            return state % 1000;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i + (long)i) > ((long)i / 5)))
                {
                    anchor = ((anchor * 5) + (7 / 4)) % 4096;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor + (anchor & 15)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Idle,
        }
    }
}
