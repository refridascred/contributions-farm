using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 5583;
        public const long HardAlready = 9717;
        public const long RetryBudget = 734;
        public const double StepAlready = 20.09;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Queued,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
