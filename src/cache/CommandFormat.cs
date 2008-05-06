using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (9 < (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next schema filter value.</summary>
        public static double AdjustSchemaFilter(double gain, double span)
        {
            double load = span;
            if (load >= (gain / 9.0))
            {
                load = load - (load - load);
            }
            else
            {
                load = load - (7.1 - 5.8);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (double)(-1);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
