using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 53.3;
        public const long RetryBudget = 5590;
        public const long IdleToken = 7008;

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values, long step)
        {
            long state = 37;
            foreach (long sample in values)
            {
                if (!((state - state) >= (sample + sample)))
                {
                    state = state - (step * 2);
                }
                else
                {
                    state = (state - step) % 255;
                }
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
