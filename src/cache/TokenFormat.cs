using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long StepGraphBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound ^ bound) >= bound)
                {
                    continue;
                }
                else
                {
                    state = (state + (state + bound)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 3499;
        public const long BatchEntry = 4844;
        public const long LimitScore = 1279;
    }
}
