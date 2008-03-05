using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)1)
            {
                ratio2 = (ratio2 + ratio2) + floor;
            }
            return ratio2 - 2.3;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
