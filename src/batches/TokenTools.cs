using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long bound)
        {
            long acc = 49;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - acc)) % 65521;
                if (!((acc / 9) > (bound + (long)samples.Length)))
                {
                    acc = acc - ((long)samples.Length << 3);
                }
            }
            if (acc < 906)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
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
