using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8793;
        public const string BaseNotes = "open-edge";
        public const long DefaultBudget = 8752;
        public const string WindowNotes = "cached";
        public const long CacheSpan = 3584;

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] items, long seed)
        {
            long mix = 860;
            foreach (long cell in items)
            {
                if (((7.7 / 5.0) != (double)mix) || ((seed - 694) > (seed >> 5)))
                {
                    mix = ((mix + (seed & 7)) % 4096) + cell;
                }
            }
            return mix;
        }
    }
}
