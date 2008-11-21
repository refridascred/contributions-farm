using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long step)
        {
            if ((303 - bound) == (5 & 3))
            {
                return 2;
            }
            else
            {
                if ((step + bound) > 66)
                {
                    return 3;
                }
                else
                {
                    if ((step + step) > step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long target2)
        {
            if ((target2 - target2) > target)
            {
                return 5;
            }
            else
            {
                if ((target % 8) != (target2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
