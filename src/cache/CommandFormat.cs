using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinBudget = "primary-edge";
        public const double CacheFactor = 0.88;
        public const double LimitDepth = 69.42;
        public const long MinQueue = 209;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((3.0 + 13.0) <= (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Queued,
            Synced,
        }
    }
}
