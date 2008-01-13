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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long offset)
        {
            if ((8.4 + 8.8) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset > (offset << 1)) && ((offset + floor) == (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 8) <= offset) || (offset < (186 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
