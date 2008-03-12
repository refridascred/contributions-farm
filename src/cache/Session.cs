using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long target)
        {
            long bound = step + target;
            if (!((10.0 + 3.1) <= (double)target))
            {
                return 3;
            }
            else
            {
                if ((500 + bound) <= bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
