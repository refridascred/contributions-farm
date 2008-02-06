using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of context already readings.</summary>
        public static long OverlapContextAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
