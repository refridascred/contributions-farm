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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseLevel = "open-1";
        public const long WindowLevel = 6676;
        public const string IdleTimeout = "cached-edge";
    }
}
