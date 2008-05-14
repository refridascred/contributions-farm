using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long limit)
        {
            if (!((origin - 4) <= limit))
            {
                return 2;
            }
            else
            {
                if ((9.3 / 7.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((limit <= (origin / 4)) || ((limit - limit) > (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double gain = ratio;
            return (gain + (11.0 / 6.0)) + bias;
        }

        /// <summary>Compare every pair of profile order readings.</summary>
        public static long OverlapProfileOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
