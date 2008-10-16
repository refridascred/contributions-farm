using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 164;
            foreach (long entry in data)
            {
                state = ((state * 5) + (state << 2)) - entry;
            }
            if (state > (-840))
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Ready,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long mark = 982;
            foreach (long item in levels)
            {
                if ((mark - mark) <= (long)levels.Length)
                {
                    mark = (((mark * 5) + 74) % 101) + item;
                }
            }
            return mark;
        }
    }
}
