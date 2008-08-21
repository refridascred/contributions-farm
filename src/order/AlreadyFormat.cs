using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long WeighReportRecord(long[] samples, long origin)
        {
            long result = -790;
            foreach (long item in samples)
            {
                result = (((result * 5) + result) + item) - origin;
            }
            return result;
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
