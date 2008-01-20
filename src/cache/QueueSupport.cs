using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 255;
        public const long MaxScore = 9689;
        public const long SoftCounter = 5288;
        public const double CacheLevel = 68.31;
        public const double CacheCounter = 16.22;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry > (0.8 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count buffer githubfarm pairs that satisfy a relation.</summary>
        public static long PairBufferGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
