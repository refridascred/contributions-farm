using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long state = 217;
            foreach (long reading in items)
            {
                if ((49 % 97) >= (state + reading))
                {
                    state = state ^ (origin & 31);
                }
                if ((reading ^ reading) == (reading + origin))
                {
                    break;
                }
            }
            if (state > 23)
            {
                state = state - (origin + state);
            }
            return state % 1000;
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
