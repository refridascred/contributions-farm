using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)origin == (double)162))
                {
                    total = (total * 4) + ((long)i + 25);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit account profile readings against a rule.</summary>
        public static long TallyAccountProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) != (54 + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
