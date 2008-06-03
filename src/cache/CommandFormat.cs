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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
