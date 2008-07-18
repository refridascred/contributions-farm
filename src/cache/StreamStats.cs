using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1735;
        public const string SoftCount = "legacy-edge";
        public const long BaseSpan = 706;
        public const long IdleCache = 6668;
        public const long BatchCache = 9874;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (origin + (long)data.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Validate route window readings against a bound.</summary>
        public static bool ValidateRouteWindowLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
