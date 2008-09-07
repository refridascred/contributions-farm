using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long anchor = 53;
            foreach (long item in levels)
            {
                if (((double)anchor <= (14.0 * 3.0)) || ((item + anchor) == ((-4) >> 5)))
                {
                    anchor = (anchor * 2) + item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long sum = 731;
            foreach (long cell in values)
            {
                if (sum > (sum + cell))
                {
                    sum = sum ^ cell;
                }
                if ((double)9 == (double)sum)
                {
                    sum = ((sum << 3) ^ (cell - sum)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (33 % 5);
                }
                if (((7.1 * 6.1) <= (double)sum) && ((2 - 11) >= sum))
                {
                    sum = (sum ^ (cell + sum)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
