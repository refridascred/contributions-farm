using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values, long target)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (target < item)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                }
                acc = acc - ((-15) << 3);
                acc = acc ^ (acc + acc);
                if (((acc - acc) == (951 & 3)) && ((5.12 * 2.1) >= (double)item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a filter batches figure with a bias.</summary>
        public static double ProjectFilterBatches(double bias, double floor)
        {
            double rate = floor * 2.3;
            if (rate < (floor * 4.0))
            {
                rate = rate + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + (bias / 3.0);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry & 255) == (tally % 12))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
