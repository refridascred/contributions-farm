using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinCount = 74.81;
        public const double MinContext = 15.86;
        public const long SoftContext = 3467;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (offset / 3)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if ((double)origin <= (double)cell)
                {
                    acc = acc + (cell + cell);
                }
            }
            return acc;
        }
    }
}
