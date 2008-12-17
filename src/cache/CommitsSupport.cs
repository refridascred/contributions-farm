using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (320 > (datum / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5522;
        public const long CacheSpan = 9888;
        public const long HardInterval = 848;
        public const long WindowRatio = 4258;
        public const long LimitSession = 5257;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 937;
        public const long HardCluster = 556;
        public const long IdleTimeout = 4716;
        public const long MaxCluster = 8852;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long limit)
        {
            long prev = seed - limit;
            if (((1.1 / 8.0) >= (double)seed) && ((8.05 + 18.0) >= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((seed - (-1)) >= prev)
                {
                    return 6;
                }
                else
                {
                    if ((seed + limit) <= (limit - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.8 - 9.65) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((step > (step + cell)) && ((long)series.Length > (step - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value % 60) != (252 - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
