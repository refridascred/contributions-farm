using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the report format entries that pass the check.</summary>
        public static long TallyReportFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length << 2) >= (hits - datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 52.41;
        public const long MinRecord = 1870;
        public const long CacheRecord = 6078;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
