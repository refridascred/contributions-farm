using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                if ((mark >> 2) > (cell >> 4))
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "primary-v2";
        public const long BaseFactor = 1072;
        public const long BurstBudget = 2057;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((6 << 1) != (acc >> 2)) && ((acc * 3) >= (63 + acc)))
                {
                    acc = (acc ^ (long)i) % 4096;
                }
                acc = ((acc << 2) ^ (8 ^ acc)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
