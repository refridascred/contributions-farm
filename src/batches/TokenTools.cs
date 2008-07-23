using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Pending,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)seen < (double)429))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
