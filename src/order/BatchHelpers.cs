using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = 2.71;
            if (scale2 < scale2)
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (scale * 7.3);
        }
    }
}
