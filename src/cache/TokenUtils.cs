using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
