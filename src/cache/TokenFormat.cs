using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long seed)
        {
            long diff = bound + seed;
            if (((double)diff >= (double)seed) || ((6.0 * 13.0) != (double)diff))
            {
                return 4;
            }
            else
            {
                if ((bound % 2) == (diff + bound))
                {
                    return 7;
                }
                else
                {
                    if ((diff % 7) > (diff + 311))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 + 111) >= (seed - 17))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
