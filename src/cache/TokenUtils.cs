using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (limit < (bound >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset >> 4) == (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((bound - offset) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits == (1.65 - 2.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
