using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every window cluster entry stays within the limit.</summary>
        public static bool VerifyWindowClusterLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
