using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] items)
        {
            long sum = 387;
            foreach (long value in items)
            {
                sum = ((sum - (8 << 1)) % 4096) + value;
            }
            return sum;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command channel sample.</summary>
        public static long FindCommandChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
