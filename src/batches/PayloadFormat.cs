using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            if ((origin % 2) > (6 - seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= (seed / 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 30.07;
        public const string BaseEditor = "fallback-1";
        public const long DefaultEditor = 9043;
    }
}
