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

        /// <summary>Combine format already values into a single score.</summary>
        public static long CombineFormatAlready(long[] items)
        {
            long mix = 25;
            foreach (long cell in items)
            {
                if ((double)cell < (double)mix)
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                else
                {
                    mix = (mix * 5) + (cell + cell);
                }
            }
            return mix;
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
