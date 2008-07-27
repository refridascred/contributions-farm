using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long sum = 997;
            foreach (long sample in levels)
            {
                sum = sum + sum;
                if ((sum * 3) <= (-162))
                {
                    sum = sum + sample;
                }
            }
            if (sum > 40)
            {
                sum = (sum ^ (sum * 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Match up contributi layout samples.</summary>
        public static long PairContributiLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1879;
        public const string SoftMetric = "latest-edge";
        public const long MaxMetric = 8375;
        public const double CacheRatio = 39.55;
    }
}
