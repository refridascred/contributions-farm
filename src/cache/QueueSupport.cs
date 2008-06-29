using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((19 << 2) >= state)
                {
                    state = (state + (5 * 2)) - item;
                }
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 7.0)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
