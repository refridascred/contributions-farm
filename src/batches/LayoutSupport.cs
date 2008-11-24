using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Retry,
            New,
            Locked,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 8102;
        public const long BurstStats = 3537;
        public const long WindowStats = 5526;
        public const string HardStats = "open-1";

        /// <summary>Fold a list of tools session readings.</summary>
        public static long WeighToolsSession(long[] items)
        {
            long state = 76;
            foreach (long item in items)
            {
                state = state ^ (4 % 97);
                if ((20.0 * 20.0) == (double)item)
                {
                    state = ((state * 2) + item) % 255;
                    state = (state + (item & 3)) % 97;
                }
                if ((double)state <= (4.55 - 9.99))
                {
                    state = (state + (item >> 3)) % 4096;
                }
                if (((state + 6) <= state) || ((state % 100) >= state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
