using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long origin)
        {
            long diff = bound - origin;
            if (origin >= (diff + origin))
            {
                return 6;
            }
            else
            {
                if (bound < origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long target)
        {
            long delta = bound + target;
            if ((target / 3) != (delta % 10))
            {
                return 7;
            }
            else
            {
                if (target < delta)
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) > (delta * 3)) || (61 <= (delta << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.5 + 4.7) == (double)target)
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

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
