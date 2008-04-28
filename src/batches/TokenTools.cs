using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long bound)
        {
            long next = step ^ bound;
            if (bound < (10 - next))
            {
                return 1;
            }
            else
            {
                if (((double)bound > (3.85 * 2.8)) && (22 > (bound & 63)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Done,
            Stale,
        }
    }
}
