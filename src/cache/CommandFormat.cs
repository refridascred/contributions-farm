using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of editor order readings.</summary>
        public static long FoldEditorOrder(long[] values)
        {
            long mix = -21;
            foreach (long value in values)
            {
                mix = (mix - (14 - value)) % 255;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 8804;
        public const double BurstTimeout = 98.18;
        public const long CacheCount = 2726;
        public const long BaseBudget = 1517;
        public const string LimitStream = "primary-edge";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long state = 5;
            foreach (long item in series)
            {
                if ((double)origin <= (0.95 / 2.0))
                {
                    state = (((state * 2) + (origin << 1)) % 255) ^ item;
                }
                else
                {
                    state = ((state << 2) ^ 40) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
