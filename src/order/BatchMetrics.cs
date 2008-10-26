using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const long DefaultAlready = 7419;
        public const long BatchTimeout = 9545;
        public const long MinAlready = 7647;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 1941;
        public const long IdleFactor = 9835;
        public const long IdleContributi = 8869;
        public const long BatchInterval = 8109;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long seed)
        {
            long sum = 612;
            foreach (long entry in levels)
            {
                if (((entry - seed) < (entry << 3)) && ((seed % 10) > (sum & 3)))
                {
                    sum = ((sum << 3) ^ (entry + 414)) % 101;
                }
                else
                {
                    sum = (sum - (entry ^ seed)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 63) >= (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }
    }
}
