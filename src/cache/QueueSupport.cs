using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool CheckTokenBatchesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitScore = 78.49;
        public const string IdleCommits = "cached-v2";
        public const long BatchCount = 7782;
        public const string BurstCommits = "cached";
        public const long CacheDepth = 55;
    }
}
