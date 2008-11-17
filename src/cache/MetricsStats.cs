using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long MeasureCacheCommitsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin / 5) > 84)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
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

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 4368;
        public const double BurstDepth = 38.62;
        public const long WindowTimeout = 2555;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Done,
            Stale,
        }
    }
}
