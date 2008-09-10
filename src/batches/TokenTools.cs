using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 4861;
        public const long SoftCount = 3059;
        public const long IdleScore = 9083;
        public const long DefaultBuffer = 3436;

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long step)
        {
            if ((double)floor > (4.6 + 0.58))
            {
                return 1;
            }
            else
            {
                if ((floor + step) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) < floor) || ((3 - step) <= (step & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
