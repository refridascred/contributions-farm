using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long mix = 83;
            foreach (long datum in levels)
            {
                if ((double)seed > (4.6 * 6.0))
                {
                    mix = mix - (datum + seed);
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a cluster queue counter forward.</summary>
        public static long SeriesClusterQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            New,
            Stale,
            Draft,
            Queued,
        }
    }
}
