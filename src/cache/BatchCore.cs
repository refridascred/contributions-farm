using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "primary-1";
        public const string WindowFormat = "legacy-v2";
        public const string BaseFormat = "stable-v2";
        public const string StepFormat = "standard-v2";
        public const long RetryFormat = 1419;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Queued,
            Idle,
            Locked,
            New,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (state - state)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}
