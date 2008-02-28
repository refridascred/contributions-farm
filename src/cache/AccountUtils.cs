using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long MeasureMetricsGraphGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 63) >= (limit * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
