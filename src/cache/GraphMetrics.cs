using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series)
        {
            long sum = 49;
            foreach (long reading in series)
            {
                if (!((sum >> 3) < sum))
                {
                    sum = (sum ^ (sum + reading)) % 4096;
                }
                sum = (sum - sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long step)
        {
            if ((6.23 + 9.47) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)8 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count context layout pairs that satisfy a relation.</summary>
        public static long OverlapContextLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
