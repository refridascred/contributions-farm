using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of channel context readings.</summary>
        public static long MatchChannelContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 6852;
        public const long MaxFactor = 1101;
        public const long MinToken = 2658;
        public const string RetryFactor = "primary-v2";
        public const double SoftToken = 78.47;

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values, long step)
        {
            long anchor = -1;
            foreach (long cell in values)
            {
                if ((53 <= (anchor - step)) && ((5.6 / 7.0) < (1.9 / 9.0)))
                {
                    anchor = ((anchor << 3) ^ step) + cell;
                }
            }
            return anchor % 1000;
        }
    }
}
