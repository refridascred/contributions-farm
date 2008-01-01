using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Match up tools route samples.</summary>
        public static long CompareToolsRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long IterateEntryCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor & 31) <= 84)
                {
                    state = state + 67;
                }
                if ((13.0 + 6.8) == (double)state)
                {
                    state = state + ((long)i & 127);
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
