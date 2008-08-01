using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long offset)
        {
            long offset2 = limit - offset;
            if (offset >= 98)
            {
                return 3;
            }
            else
            {
                if ((offset2 + offset) < limit)
                {
                    return 7;
                }
                else
                {
                    if (!((offset2 / 5) != (limit << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long step = origin ^ floor;
            if (step > (floor >> 5))
            {
                return 6;
            }
            else
            {
                if ((floor ^ floor) < (1 + origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
