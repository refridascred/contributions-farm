using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long ScoreToolsCommand(long[] data, long bound)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if (bound < cell)
                {
                    state = (state * 5) + ((-1) * 5);
                }
                else
                {
                    state = state - 876;
                }
            }
            if (state < 976)
            {
                state = ((state << 3) ^ (state + 21)) % 101;
            }
            return state;
        }
    }
}
