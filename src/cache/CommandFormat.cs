using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long sum = -17;
            foreach (long entry in data)
            {
                if (!(((-6) << 3) < (entry / 9)))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long FindClusterContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long origin)
        {
            long mark = 719;
            foreach (long reading in items)
            {
                if ((origin > (mark + reading)) && ((origin / 9) > mark))
                {
                    mark = ((mark << 3) ^ (mark - mark)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2612;
        public const long WindowDepth = 6679;
        public const long DefaultSpan = 2705;
        public const long IdleSchema = 7837;
    }
}
