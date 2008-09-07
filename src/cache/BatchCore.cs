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

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 34.51;
        public const long IdleSchema = 1901;
        public const double WindowFactor = 49.63;
        public const long MinScore = 7411;

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
