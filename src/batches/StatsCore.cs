using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many notes entry samples are out of range.</summary>
        public static long CountNotesEntryOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count - limit) != (cell - count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Closed,
            Ready,
            Done,
            Stale,
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
