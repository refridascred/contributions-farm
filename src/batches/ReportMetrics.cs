using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate support stream readings against a bound.</summary>
        public static bool VerifySupportStreamLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if (!((26 << 2) >= (step % 12)))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (2.0 * 5.4)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
