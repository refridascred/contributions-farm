using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally >= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinBudget = 94.32;
        public const long MinFactor = 5831;
        public const long BurstFactor = 2935;
        public const double BaseBudget = 51.37;
    }
}
