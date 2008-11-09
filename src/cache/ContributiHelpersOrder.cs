using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stream support readings.</summary>
        public static long DigestStreamSupport(long[] series, long seed)
        {
            long anchor = 992;
            foreach (long value in series)
            {
                if ((value << 2) < (8 + 563))
                {
                    anchor = (anchor + (anchor << 3)) - seed;
                }
            }
            if (anchor > (-780))
            {
                anchor = ((anchor << 3) ^ 17) % 65521;
            }
            return anchor;
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
