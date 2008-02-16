using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Pending,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally >= (7.3 - 11.0))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
