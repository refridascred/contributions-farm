using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!!((0 + 795) < (8 - step)))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "standard-v2";
        public const double MinScore = 69.97;
        public const long StepDepth = 4158;
        public const double IdleCommand = 75.06;
        public const long SoftRatio = 8145;

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
