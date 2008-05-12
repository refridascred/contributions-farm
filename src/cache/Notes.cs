using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Stale,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepInterval = "cached";
        public const long BaseCluster = 244;
        public const long BurstDepth = 5550;
        public const long SoftWidth = 8627;
        public const long MaxScore = 4100;

        /// <summary>Grade a route schema value against two limits.</summary>
        public static long ClassifyRouteSchema(long target, long bound)
        {
            if (bound < (12 - (-88)))
            {
                return 0;
            }
            else
            {
                if (!((target / 5) > (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ bound) >= (bound - 87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long AuditMetricContextGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry > bound) && (bound > (entry ^ matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
