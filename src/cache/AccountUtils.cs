using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 / 8) > (matches >> 3))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            New,
            Failed,
        }
    }
}
