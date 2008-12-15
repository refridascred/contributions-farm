using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
