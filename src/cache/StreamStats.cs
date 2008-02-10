using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long origin)
        {
            long anchor = 11;
            foreach (long value in items)
            {
                if ((origin <= (origin + 881)) && ((double)value > 8.9))
                {
                    anchor = anchor ^ origin;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((double)tally < (8.0 * 18.0)))
                {
                    tally = ((tally + 2) - sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinDepth = 3180;
        public const double IdleDepth = 45.84;
        public const long BaseCount = 4602;
        public const long BurstWidth = 1319;
        public const string CacheBudget = "open-1";

        /// <summary>Find the first contributi checks entry that matches the target.</summary>
        public static long FindContributiChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
