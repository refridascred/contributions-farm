using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (2.7 + offset);
            }
            return drift - 6.08;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if ((429 - origin) < (2 % 100))
            {
                return 7;
            }
            else
            {
                if (909 < bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
