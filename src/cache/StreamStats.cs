using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi cache samples.</summary>
        public static long ScoreContributiCache(long[] data, long bound)
        {
            long acc = -44;
            foreach (long cell in data)
            {
                acc = ((acc ^ ((-345) ^ cell)) % 255) - bound;
            }
            return acc;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long AuditSchemaChecksHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (origin <= (87 + seen))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchRatio = "standard-v2";
        public const long MinContext = 5264;
        public const long IdleContext = 356;
        public const long SoftFactor = 3270;

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long limit)
        {
            long span = target ^ limit;
            if (!((span - span) <= span))
            {
                return 7;
            }
            else
            {
                if ((limit - target) == (limit - 265))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) != (95 + 64))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
