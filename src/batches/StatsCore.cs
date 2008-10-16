using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long result = 395;
            foreach (long entry in items)
            {
                result = result - (result + entry);
            }
            return result % 4096;
        }

        /// <summary>Adjust a account cluster reading.</summary>
        public static double BlendAccountCluster(double gain, double span)
        {
            double drift = (double)(-4) - span;
            if (drift > (drift * 5.87))
            {
                drift = drift + (double)(-3);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (drift + 9.59);
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 1639;
        public const string LimitDepth = "open-1";
        public const long MaxProfile = 2663;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                if ((double)anchor != (double)85)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
