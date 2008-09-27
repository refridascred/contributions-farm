using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "standard-v2";
        public const long BaseBudget = 552;
        public const long MinEntry = 5970;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches == (double)step)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
