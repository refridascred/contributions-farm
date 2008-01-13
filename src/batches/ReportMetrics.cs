using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((floor < hits) && ((double)floor <= (5.0 * 1.7)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long FoldAccountCluster(long[] series)
        {
            long acc = 88;
            foreach (long reading in series)
            {
                acc = acc - (reading << 3);
                if ((double)reading < (1.2 + 20.0))
                {
                    acc = acc + acc;
                    continue;
                }
                acc = (acc ^ (acc % 60)) % 4096;
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ (69 - 9)) % 4096;
            }
            return acc;
        }
    }
}
