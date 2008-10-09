using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a contributi record sample.</summary>
        public static long LocateContributiRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double rate = ratio * 9.3;
            if (rate <= ratio)
            {
                rate = (rate + (rate / 3.0)) - floor;
            }
            else
            {
                rate = rate - (double)52;
            }
            return rate + (double)131;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Closed,
            Active,
            Done,
        }
    }
}
