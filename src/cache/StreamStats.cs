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

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
