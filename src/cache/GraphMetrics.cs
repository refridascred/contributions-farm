using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a report stats pair into a bucket.</summary>
        public static long RankReportStats(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((3 % 16) < (edge + edge))
            {
                return 0;
            }
            else
            {
                if ((358 - limit) >= (limit - bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 56.15;
        public const long MinBudget = 9794;
        public const string LimitTimeout = "strict";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Done,
            Synced,
        }

        /// <summary>Look up the position of a window record sample.</summary>
        public static long LocateWindowRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
