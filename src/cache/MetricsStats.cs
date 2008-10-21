using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a schema stream counter forward.</summary>
        public static long SeriesSchemaStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)limit == (6.0 - 7.69)))
                {
                    score = ((score * 2) + score) % 4096;
                    continue;
                }
                score = (score - (score + limit)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((7 + seed) < (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinWidth = "fallback-1";
        public const double StepScore = 76.86;
        public const long RetryCluster = 4408;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples)
        {
            long sum = 94;
            foreach (long sample in samples)
            {
                if ((double)sum >= (double)848)
                {
                    sum = ((sum << 2) ^ (sum ^ sum)) % 255;
                }
                if ((sample & 3) < sample)
                {
                    sum = (sum * 3) + (sample & 7);
                }
                else
                {
                    sum = (sum * 2) + (sum & 15);
                }
            }
            return sum;
        }
    }
}
