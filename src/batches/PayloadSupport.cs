using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (6.88 * 1.78))
            {
                bias2 = bias2 - (double)81;
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
