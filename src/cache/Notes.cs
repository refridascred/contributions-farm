using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long floor)
        {
            if (((target + target) > (target + floor)) || (((-280) ^ target) == (target >> 5)))
            {
                return 1;
            }
            else
            {
                if (0.28 > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!((3 + floor) < (target - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            long next = step + bound;
            if ((double)bound >= (7.8 + 18.0))
            {
                return 5;
            }
            else
            {
                if (next < (1 % 10))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit metrics support readings against a rule.</summary>
        public static long AuditMetricsSupportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((17.0 / 4.0) != (double)hits) || !((2.9 + 5.55) != (double)offset))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
