using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((step - item) >= step) && (matches >= (item ^ matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxLevel = 43.02;
        public const long SoftNotes = 570;
        public const long BatchNotes = 5903;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
