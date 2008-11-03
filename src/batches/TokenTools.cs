using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream graph value from a seed.</summary>
        public static long IterateStreamGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((state ^ state) > (long)i)
                {
                    state = state - ((long)i & 31);
                    state = state + origin;
                }
                state = state + ((long)i + origin);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Synced,
            New,
        }
    }
}
