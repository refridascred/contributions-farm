using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if (((double)88 <= (double)origin) || ((double)target == (2.6 * 0.15)))
            {
                return 2;
            }
            else
            {
                if (3.25 < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >= (entry % 3)) && ((seen + entry) == ((-580) % 97)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
