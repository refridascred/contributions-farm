using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long GradeSupportMetric(long target, long target2)
        {
            long offset = target + target2;
            if (!(offset < (target - target)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target / 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long seed)
        {
            long mix = 922;
            foreach (long datum in levels)
            {
                if (mix > (seed % 10))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
