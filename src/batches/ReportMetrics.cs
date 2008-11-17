using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long origin)
        {
            long score = -50;
            foreach (long sample in series)
            {
                if (!((origin / 3) <= (score - (long)series.Length)))
                {
                    score = (score ^ (sample - (long)series.Length)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
