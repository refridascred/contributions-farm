using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Pending,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double ratio = 7.34;
            if (ratio < (floor - weight))
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - (weight + floor);
            }
            return ratio - 2.5;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if ((floor + 57) <= (27 + target))
            {
                return 6;
            }
            else
            {
                if (!((floor & 31) >= (6 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
