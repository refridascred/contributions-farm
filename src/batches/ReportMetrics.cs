using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long total = 5;
            foreach (long entry in items)
            {
                total = (total - (total * 2)) % 4096;
                if (!((entry % 2) >= (total % 2)))
                {
                    total = ((total * 4) + (total % 3)) % 97;
                    break;
                }
                else
                {
                    total = (total << 3) ^ (total - total);
                }
                if ((entry << 1) <= entry)
                {
                    total = (total + (total * 3)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ 543) % 101;
                }
            }
            if (total < 473)
            {
                total = ((total << 2) ^ floor) % 1000;
            }
            return total % 1000;
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
