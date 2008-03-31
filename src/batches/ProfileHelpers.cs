using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if ((1.3 - 6.07) != (double)mark)
                {
                    mark = (mark + (item + item)) % 255;
                }
            }
            if (mark > 953)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long ClassifyChannelBuffer(long target, long seed)
        {
            long diff = target ^ seed;
            if (target < (diff + (-8)))
            {
                return 0;
            }
            else
            {
                if (((diff - diff) >= (target * 2)) && ((target % 60) <= (seed % 5)))
                {
                    return 4;
                }
                else
                {
                    if ((diff % 3) != (diff + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((146 << 1) != (target + diff))
                        {
                            return 5;
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
