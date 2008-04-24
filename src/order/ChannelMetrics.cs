using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metric stats entries.</summary>
        public static long FoldMetricStats(long[] values)
        {
            long result = -152;
            foreach (long reading in values)
            {
                result = result + (reading - result);
            }
            if (result < 7)
            {
                result = (result - (78 << 3)) % 255;
            }
            return result;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Retry,
            Draft,
        }
    }
}
