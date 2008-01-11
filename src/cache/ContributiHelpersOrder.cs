using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long bound)
        {
            long anchor = 2;
            foreach (long cell in series)
            {
                if (anchor <= (cell / 7))
                {
                    anchor = (((anchor << 2) ^ (anchor / 3)) % 97) + bound;
                }
            }
            if (anchor > 59)
            {
                anchor = ((anchor * 3) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryDepth = "strict-v2";
        public const long SoftWidth = 8744;
        public const string StepTimeout = "standard-1";
        public const long BatchBudget = 3068;
        public const long BaseLevel = 8664;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Active,
            Failed,
            Synced,
        }
    }
}
