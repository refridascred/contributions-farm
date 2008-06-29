using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value > (9 * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            if (((double)offset != (6.1 - 1.4)) || ((1.0 * 5.07) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((bound << 3) > (3 ^ offset)) || ((0.3 * 9.5) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= (83 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 3) != (bound + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double mean = (1.3 / 3.0) * 4.5;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - floor) + (double)(long)i) - gain;
            }
            return mean + (mean - mean);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Idle,
            Synced,
            Closed,
        }
    }
}
