using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine layout already values into a single score.</summary>
        public static long TallyLayoutAlready(long[] values, long seed)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                mark = (mark - (488 >> 3)) % 101;
                mark = (mark - entry) % 97;
            }
            if (mark > 5)
            {
                mark = (mark - (seed << 3)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!(((3.17 / 4.0) < (double)bound) && ((bound << 2) > ((long)i + (long)i))))
                {
                    result = (result + (bound + bound)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 3433;
        public const long CacheBudget = 1131;
        public const long WindowGraph = 8325;
        public const long RetryGraph = 4101;
        public const string WindowSize = "alpha-edge";
    }
}
