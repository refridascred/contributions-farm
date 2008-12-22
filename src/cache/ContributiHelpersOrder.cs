using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2713;
        public const double BurstCounter = 32.17;
        public const string CacheSize = "alpha-v2";
        public const string MaxCounter = "strict-v2";

        /// <summary>Audit support command readings against a rule.</summary>
        public static long TallySupportCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((count + value) < floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 15) > tally)
                {
                    tally = (tally + 2) + step;
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
