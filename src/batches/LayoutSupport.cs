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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long total = 177;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long limit)
        {
            if (1.9 <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset & 7))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftWidth = "staging";
        public const long BatchEditor = 9448;
        public const long BaseTimeout = 4821;
        public const string MaxEditor = "strict-edge";
        public const string WindowEditor = "alpha";
    }
}
