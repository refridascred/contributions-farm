using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if ((datum >> 4) <= 5)
                {
                    mark = (mark - (1 >> 4)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 5503;
        public const long BatchBatches = 3749;
        public const double MinCount = 68.49;
    }
}
