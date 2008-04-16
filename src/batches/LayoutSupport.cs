using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long MeasureRouteOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((double)item >= 5.0) || ((item >> 1) >= item)) || ((count + item) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1257;
        public const long SoftLevel = 4621;
        public const long HardOrder = 2869;
        public const long LimitOrder = 7385;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
