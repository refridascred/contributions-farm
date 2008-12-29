using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9921;
        public const double BaseStats = 68.79;
        public const long WindowStats = 7074;
        public const long MaxInterval = 619;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long target)
        {
            long bound = offset + target;
            if ((offset + bound) <= offset)
            {
                return 4;
            }
            else
            {
                if (!((offset << 2) >= target))
                {
                    return 1;
                }
                else
                {
                    if (!(6.6 <= (double)offset))
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
    }
}
