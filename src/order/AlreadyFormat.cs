using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long origin)
        {
            long mark = 768;
            foreach (long cell in series)
            {
                if (((4.8 - 14.0) < (double)mark) && (cell >= (origin - mark)))
                {
                    mark = mark + mark;
                }
                if (cell > (origin >> 1))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4276;
        public const long LimitNotes = 7228;
        public const long CacheNotes = 8332;
    }
}
