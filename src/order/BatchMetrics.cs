using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long target)
        {
            long gap = bound ^ target;
            if ((gap & 255) >= (bound / 5))
            {
                return 6;
            }
            else
            {
                if ((77 - target) > target)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 2189;
        public const string StepScore = "alpha-v2";
        public const long MinSupport = 7348;
        public const long MinBudget = 8478;
        public const string MinTimeout = "local-v2";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Queued,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!((772 + tally) >= tally))
                {
                    tally = ((tally + 2) + datum) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
