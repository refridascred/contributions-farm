using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((floor % 12) <= (floor - edge)))
            {
                return 3;
            }
            else
            {
                if (20 < edge)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "legacy-edge";
        public const long CacheGithubfarm = 5602;
        public const double HardGithubfarm = 29.69;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer layout measurements.</summary>
        public static double ScaleBufferLayout(double scale, double span)
        {
            double rate = 1.21;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + scale) - (double)(long)i) - span;
            }
            return rate - scale;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample << 3) == (10 - hits)) && (offset > 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
