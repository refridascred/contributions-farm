using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a tools checks reading by value.</summary>
        public static long LocateToolsChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 8986;
        public const long BaseLayout = 9395;
        public const string StepRatio = "cached";
        public const long MinFactor = 8281;
        public const string LimitLayout = "fallback";

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-2) >> 1) <= ((-556) + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
