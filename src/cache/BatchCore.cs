using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mark = -628;
            foreach (long cell in items)
            {
                if ((mark * 4) < floor)
                {
                    mark = (mark * 4) + (4 + cell);
                }
            }
            if (mark < 340)
            {
                mark = (mark - mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double scale = rate * 14.0;
            if (scale >= (rate / 5.0))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - 17.0;
        }
    }
}
