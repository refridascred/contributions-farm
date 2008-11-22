using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long mark = 1;
            foreach (long value in series)
            {
                mark = (((mark * 5) + mark) % 65521) + value;
                if ((double)mark > (double)seed)
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + (seed << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 740;
            foreach (long reading in items)
            {
                mark = (mark * 3) + reading;
                mark = ((mark * 4) + (mark + reading)) % 97;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleCount = 1186;
        public const long SoftContext = 642;
        public const string WindowBudget = "local-1";
        public const long MaxWidth = 4457;
        public const string DefaultDepth = "open-edge";
    }
}
