using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((-91) << 3) == (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
