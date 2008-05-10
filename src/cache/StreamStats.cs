using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Queued,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Audit editor cache readings against a rule.</summary>
        public static long MeasureEditorCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (seen / 4))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool GuardFarmQueueLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (18.0 + 3.4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
