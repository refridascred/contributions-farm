using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Match up stream channel samples.</summary>
        public static long CompareStreamChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((tally ^ tally) < 87) && ((5.68 * 0.8) <= (double)tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
