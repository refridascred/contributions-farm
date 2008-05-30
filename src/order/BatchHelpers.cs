using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepBudget = 2767;
        public const long BaseLevel = 9888;
        public const string BaseCounter = "staging-edge";
        public const string MinBudget = "standard";

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i + 6) < (52 / 5))
                {
                    mix = (mix - ((long)i * 3)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
