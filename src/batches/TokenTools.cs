using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Synced,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor % 24) <= (state + (long)i))
                {
                    state = state ^ (floor - state);
                }
                if (!(9.0 <= (double)floor))
                {
                    state = (state - (long)i) % 65521;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
