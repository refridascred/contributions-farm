using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long limit)
        {
            if ((double)limit == (4.42 / 6.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit < 3.75)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series)
        {
            long sum = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum + (sum ^ (long)series.Length)) ^ (long)i;
                }
                sum = ((sum << 2) ^ (sum ^ 408)) % 255;
                if ((entry >= (sum * 3)) && ((double)entry >= (14.0 / 5.0)))
                {
                    sum = (sum * 4) + (sum >> 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a profile window value against two limits.</summary>
        public static long RankProfileWindow(long seed, long limit)
        {
            if ((seed ^ seed) != (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (15.0 + 9.2))
                {
                    return 2;
                }
                else
                {
                    if (((limit + limit) < seed) || ((seed - seed) > (limit - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + (-47)) > (limit & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepCount = "local";
        public const string BaseEntry = "standard";
        public const string SoftWidth = "local-edge";
        public const string CacheEntry = "latest-1";
        public const long IdleEntry = 253;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((76 + count) >= (datum + datum))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
