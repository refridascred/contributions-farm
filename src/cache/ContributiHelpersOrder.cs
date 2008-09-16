using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((2 + entry) >= 773)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every format schema entry stays within the limit.</summary>
        public static bool CheckFormatSchemaRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
