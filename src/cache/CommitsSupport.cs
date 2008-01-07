using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const string SoftBatch = "latest-1";
        public const long MinLevel = 4991;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ state;
                state = ((state * 2) + bound) % 1000;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state ^ (state + (long)i2)) % 65521;
                    state = (state + (bound + (long)i)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long seed2)
        {
            if (seed2 <= (seed2 + seed2))
            {
                return 6;
            }
            else
            {
                if ((seed2 - 493) <= (seed2 * 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Dropped,
            Paused,
            New,
            Failed,
        }
    }
}
