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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
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

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double load = span * 4.11;
            for (int i = 0; i < 2; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - (load + load);
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
