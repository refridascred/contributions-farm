using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double bias3 = (double)650 - (bias2 - 7.19);
            if (bias3 < (bias3 * 3.58))
            {
                bias3 = bias3 - (double)(-78);
            }
            return bias3 + (bias - bias2);
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
