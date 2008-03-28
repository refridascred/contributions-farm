using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter support samples.</summary>
        public static long FoldCounterSupport(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = (((acc * 2) + (-195)) % 65521) - value;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 1288;
        public const long WindowBuffer = 8017;
        public const string RetryScore = "strict-1";
        public const long BatchBuffer = 9413;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (((double)offset < (19.0 / 7.0)) && (floor <= offset))
            {
                return 3;
            }
            else
            {
                if ((diff + diff) >= (offset - 5))
                {
                    return 0;
                }
                else
                {
                    if (((diff / 5) < diff) || (offset > (offset * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
