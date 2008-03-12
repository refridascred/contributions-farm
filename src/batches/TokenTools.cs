using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "alpha-1";
        public const long MaxBudget = 1346;
        public const double BatchCount = 80.47;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
