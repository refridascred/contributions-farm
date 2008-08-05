using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if (78 > (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 20.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 + seed) >= (48 * 5))
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long offset)
        {
            if ((1.09 * 15.0) < (double)offset)
            {
                return 6;
            }
            else
            {
                if (((7.3 - 9.2) > (double)target) && ((target >> 4) <= (592 / 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
