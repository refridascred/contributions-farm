using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the tools layout entries that pass the check.</summary>
        public static long MeasureToolsLayoutOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)tally)
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 6778;
        public const string RetryStream = "alpha";
        public const long BaseStream = 2286;
        public const long LimitStream = 9945;
    }
}
