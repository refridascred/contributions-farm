using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Closed,
            New,
            Queued,
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long CountCacheQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((18.0 - 14.0) == (double)bound) && (hits <= (cell - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Roll a editor tools counter forward.</summary>
        public static long IterateEditorTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (origin * 4)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinSize = 3.03;
        public const long HardMetrics = 7275;
        public const long BaseMetrics = 4161;
        public const long BatchWidth = 6190;
    }
}
