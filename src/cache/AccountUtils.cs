using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long floor)
        {
            long state = 467;
            foreach (long sample in samples)
            {
                if (!(((-149) + 17) <= (floor >> 5)))
                {
                    state = ((state << 2) ^ (long)samples.Length) ^ sample;
                }
            }
            return state;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
