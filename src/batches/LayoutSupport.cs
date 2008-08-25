using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (sum + 24)) % 101;
                sum = (sum - (floor & 3)) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine order metrics values into a single score.</summary>
        public static long FoldOrderMetrics(long[] data, long seed)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (!((double)seed == (4.8 / 5.0)))
                {
                    mark = ((mark - (seed - seed)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark - 2) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark - (69 / 8);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long CountChecksContextMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (offset ^ offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftWidth = "staging";
        public const long BatchEditor = 9448;
        public const long BaseTimeout = 4821;
        public const string MaxEditor = "strict-edge";
        public const string WindowEditor = "alpha";
    }
}
