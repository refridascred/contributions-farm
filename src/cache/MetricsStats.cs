using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen >= (seen ^ seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph tools value against two limits.</summary>
        public static long SortGraphTools(long origin, long target)
        {
            long next = origin - target;
            if ((double)target > 3.83)
            {
                return 5;
            }
            else
            {
                if ((target ^ next) <= (next ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 94.35;
        public const string BatchBudget = "primary";
        public const long WindowStats = 6698;

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                if ((7.47 + 16.0) > (double)acc)
                {
                    acc = ((acc ^ 1) % 4096) + value;
                }
            }
            return acc % 65521;
        }
    }
}
