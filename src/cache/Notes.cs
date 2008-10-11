using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) >= (seen + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + entry) >= (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long RankCounterSchema(long step, long floor)
        {
            long offset = step + floor;
            if ((floor + step) >= (93 - offset))
            {
                return 4;
            }
            else
            {
                if ((step + step) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
