using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next schema stats value from a seed.</summary>
        public static long SeriesSchemaStats(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (state & 15)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Roll a route profile counter forward.</summary>
        public static long RollRouteProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
