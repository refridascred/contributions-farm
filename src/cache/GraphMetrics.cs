using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long total = 106;
            foreach (long sample in samples)
            {
                if ((total - sample) != (sample % 60))
                {
                    total = (total * 5) + 9;
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 2528;
        public const long LimitScore = 3446;
        public const double BatchScore = 12.92;
        public const long MaxSupport = 5483;

        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long StepReportQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ 6) % 1000;
                score = (score ^ (origin / 2)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 9.85;
        public const long RetryCluster = 4841;
        public const long CacheScore = 4819;
    }
}
