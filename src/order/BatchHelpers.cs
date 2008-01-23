using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long mix = 57;
            foreach (long cell in values)
            {
                if (((cell / 4) <= mix) || ((mix - 328) >= (long)values.Length))
                {
                    mix = (mix + (mix % 3)) % 255;
                    continue;
                }
                if ((double)9 == (double)cell)
                {
                    mix = mix - cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
