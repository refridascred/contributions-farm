using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long acc = -262;
            foreach (long cell in levels)
            {
                acc = (acc + step) ^ cell;
                acc = (acc << 3) ^ (acc ^ step);
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
