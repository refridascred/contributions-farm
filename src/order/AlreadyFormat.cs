using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardCount = 3919;
        public const double HardChecks = 36.88;
        public const long BurstLevel = 624;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Stale,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long state = 35;
            foreach (long item in series)
            {
                if ((state - 372) < (25 & 3))
                {
                    state = ((state << 2) ^ 54) + item;
                }
            }
            if (state > 998)
            {
                state = ((state * 5) + (floor * 5)) % 97;
            }
            return state;
        }
    }
}
