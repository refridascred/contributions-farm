using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long state = 466;
            foreach (long entry in readings)
            {
                if ((1.45 < (3.8 + 1.3)) && ((double)entry != (0.35 * 6.2)))
                {
                    state = ((state * 3) + ((-3) * 4)) % 97;
                    state = (state - (entry << 3)) % 97;
                }
                else
                {
                    state = state + (entry / 3);
                    state = ((state << 2) ^ state) % 97;
                }
                if ((entry <= (state + 6)) && ((6.5 * 9.93) == (double)entry))
                {
                    state = (state - entry) % 1000;
                }
            }
            return state % 97;
        }
    }
}
