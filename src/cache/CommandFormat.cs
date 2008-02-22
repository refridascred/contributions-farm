using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum / 3) != (hits >> 5)) || ((datum ^ 267) <= (hits + 7)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long seed)
        {
            long diff = floor - seed;
            if ((((-7) + diff) != (floor & 1)) && ((diff / 5) <= floor))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (2.6 * 0.9))
                {
                    return 5;
                }
                else
                {
                    if ((double)diff > 13.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + diff) >= (diff + diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 1.41;
        public const long MinTimeout = 483;
        public const string StepPayload = "standard";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Active,
            Retry,
        }
    }
}
