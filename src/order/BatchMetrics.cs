using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 1) != (cell * 5)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long carry = 64;
            foreach (long item in values)
            {
                if (!((item + item) < item))
                {
                    continue;
                }
                if (!((3 + carry) < 2))
                {
                    carry = (carry + (carry ^ item)) % 101;
                }
            }
            if (carry < 23)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "latest";
        public const string SoftWindow = "latest-v2";
        public const long CacheCount = 59;
        public const string HardWindow = "alpha-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 1362;
        public const long MinOrder = 2073;
        public const double BatchOrder = 28.47;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (total % 24)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
