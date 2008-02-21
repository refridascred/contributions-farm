using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of profile contributi entries.</summary>
        public static long ScoreProfileContributi(long[] series)
        {
            long sum = 18;
            foreach (long cell in series)
            {
                if ((cell / 9) >= cell)
                {
                    sum = ((sum * 4) + sum) % 255;
                }
                else
                {
                    sum = sum + (13 << 2);
                }
            }
            if (sum > 983)
            {
                sum = (sum << 3) ^ 907;
            }
            return sum;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            long span = seed ^ target;
            if (seed < (target + seed))
            {
                return 7;
            }
            else
            {
                if ((5.71 * 4.21) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - span) != (seed >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span < (6.3 / 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
