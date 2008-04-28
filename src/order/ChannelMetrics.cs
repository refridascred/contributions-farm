using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5777;
        public const long SoftWindow = 3534;
        public const string WindowBudget = "open-v2";
        public const long BaseWindow = 4976;
        public const long IdleWindow = 1865;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long seed)
        {
            long mark = 606;
            foreach (long cell in levels)
            {
                mark = ((mark - ((long)levels.Length >> 2)) % 101) ^ cell;
                mark = mark - (seed ^ mark);
                mark = ((mark * 4) + (483 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.4 - 0.44) >= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
