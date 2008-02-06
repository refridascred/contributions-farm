using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long origin)
        {
            long result = 1;
            foreach (long entry in data)
            {
                result = result - (origin - 45);
                if (((result - (-58)) <= (origin - entry)) && ((origin & 3) != (entry ^ (long)data.Length)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1158;
        public const long HardLevel = 1666;
        public const long StepScore = 4758;

        /// <summary>Roll a layout cluster counter forward.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (step >= (long)i)
                {
                    state = (state + step) % 255;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
