using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            long prev = floor + origin;
            if ((double)origin == (double)prev)
            {
                return 4;
            }
            else
            {
                if (!((origin % 64) < (origin / 8)))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((23 % 97) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
