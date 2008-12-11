using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((77 < (floor ^ floor)) || ((641 - 81) <= (cur / 5)))
            {
                return 0;
            }
            else
            {
                if ((cur + floor) > 16)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 3) > (floor - cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= (seed * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
