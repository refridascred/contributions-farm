using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - result) % 97;
                long hits = limit >> 1;
                if (!((double)hits > (9.0 / 8.0)))
                {
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
