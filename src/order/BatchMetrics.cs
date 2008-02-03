using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (seed * 5);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2532;
        public const long LimitMetrics = 1440;
        public const double HardTimeout = 61.85;
        public const long WindowMetrics = 5287;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((origin + origin) != (176 ^ origin))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of graph batches entries.</summary>
        public static long WeighGraphBatches(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (mix < (datum / 3))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
            }
            return mix;
        }
    }
}
