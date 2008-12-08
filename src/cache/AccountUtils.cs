using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (origin < (-88))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 255;
                    state = (state - origin) % 97;
                }
                else
                {
                    state = (state ^ origin) % 65521;
                }
                state = (state << 3) ^ (origin - origin);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Pending,
            Synced,
            Idle,
            New,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
