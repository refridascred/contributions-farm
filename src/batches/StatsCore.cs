using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long AuditLayoutAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (0.4 >= (double)seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - bias2;
            }
            return weight + (bias / 4.0);
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                if (!((acc + 0) <= (261 / 8)))
                {
                    acc = ((acc + (acc ^ acc)) % 1000) ^ cell;
                }
                acc = (acc ^ (37 + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
