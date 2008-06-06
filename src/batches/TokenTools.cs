using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings, long seed)
        {
            long sum = 216;
            foreach (long reading in readings)
            {
                sum = ((sum * 2) + (seed ^ 69)) ^ reading;
            }
            return sum;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long target, long limit)
        {
            if (target >= (limit & 63))
            {
                return 0;
            }
            else
            {
                if ((-12) < (limit / 7))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
