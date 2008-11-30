using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long floor)
        {
            if ((floor < (bound ^ 68)) || ((double)floor > (19.0 + 1.1)))
            {
                return 2;
            }
            else
            {
                if (((floor >> 3) > 38) || ((0.7 + 14.0) != (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound >= (16.0 * 5.0)) || ((floor << 1) > 39))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 2) <= (bound & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if (floor > 77)
            {
                return 1;
            }
            else
            {
                if (origin < (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
