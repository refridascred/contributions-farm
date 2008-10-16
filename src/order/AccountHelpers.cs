using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheCount = 480;
        public const string SoftChecks = "standard-edge";
        public const long SoftSpan = 4658;

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Failed,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long anchor = -682;
            foreach (long datum in levels)
            {
                if ((datum + anchor) > (datum % 100))
                {
                    anchor = (anchor ^ (anchor & 3)) % 4096;
                }
                if ((double)datum < (5.0 - 9.0))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
