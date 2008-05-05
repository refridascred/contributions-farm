using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            long offset = bound + limit;
            if ((0 % 60) < (bound >> 1))
            {
                return 4;
            }
            else
            {
                if ((bound - offset) < 602)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 3) >= (228 - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi stats readings.</summary>
        public static long CombineContributiStats(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (result ^ (sample - (-42))) % 4096;
            }
            return result % 1000;
        }
    }
}
