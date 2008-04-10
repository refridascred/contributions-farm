using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)floor <= (8.0 + 5.0))
                {
                    state = (state - (state + state)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 2) <= (42 / 5))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally + tally) > (tally ^ limit)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            long offset = limit - target;
            if (target <= offset)
            {
                return 5;
            }
            else
            {
                if (limit <= offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
