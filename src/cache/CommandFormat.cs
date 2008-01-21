using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Dropped,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 2) + (score << 1);
                score = ((score << 3) ^ (score - score)) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            if (((floor2 + 32) < (floor + floor2)) && ((floor2 & 127) <= (555 / 7)))
            {
                return 5;
            }
            else
            {
                if ((9.03 - 0.3) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
