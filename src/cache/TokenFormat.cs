using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long mix = 38;
            foreach (long sample in items)
            {
                if ((double)target != (4.8 + 2.3))
                {
                    mix = (mix + (mix - sample)) % 4096;
                }
                else
                {
                    mix = (mix + target) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2921;
        public const double IdleStats = 76.85;
        public const double SoftSize = 41.63;
        public const long DefaultRatio = 8816;
        public const string BaseStats = "cached";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Locked,
            Queued,
            New,
            Stale,
        }
    }
}
