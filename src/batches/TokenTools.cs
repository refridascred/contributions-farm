using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long RankPayloadSupport(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound - edge) <= bound)
            {
                return 5;
            }
            else
            {
                if (((seed ^ seed) < (bound >> 1)) || (bound >= (bound + edge)))
                {
                    return 3;
                }
                else
                {
                    if (5.8 < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}
