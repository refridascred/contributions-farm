using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of queue session readings.</summary>
        public static long CombineQueueSession(long[] items)
        {
            long anchor = 535;
            foreach (long sample in items)
            {
                anchor = (anchor - (5 >> 3)) % 4096;
                if ((sample - sample) <= (sample / 4))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 2622;
        public const long MaxSpan = 8223;
        public const string CacheTimeout = "stable-1";
        public const long LimitDepth = 9318;
        public const double HardRecord = 48.0;

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long MeasureFilterStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + tally) < (cell & 3))
                {
                    tally = tally + 2;
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
