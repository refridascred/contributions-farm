using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((6.9 - 10.0) < (double)matches))
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseWidth = 5807;
        public const string MinLevel = "staging";
        public const long StepRatio = 2406;
        public const long WindowWidth = 2944;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "primary-v2";
        public const long MinSchema = 8387;
        public const long CacheInterval = 5794;
        public const string BurstSchema = "legacy";

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long limit)
        {
            if (limit < (limit / 7))
            {
                return 4;
            }
            else
            {
                if (((double)limit == (4.7 + 14.0)) && ((target << 3) != (435 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) <= (56 * 2)) && ((limit + limit) >= (limit >> 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((387 * 5) < limit) && ((6.0 + 8.7) == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
