using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a command token reading by value.</summary>
        public static long LookupCommandTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            Synced,
            Retry,
            New,
        }

        /// <summary>Audit batches route readings against a rule.</summary>
        public static long MeasureBatchesRouteOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches <= 1.6)
                {
                    matches = ((matches + 3) ^ datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((3 << 1) > matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Retry,
            Pending,
            Draft,
            Queued,
        }
    }
}
