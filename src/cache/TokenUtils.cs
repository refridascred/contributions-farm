using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long acc = 991;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc ^ (datum & 1)) % 97) ^ (long)i;
                }
                acc = (acc ^ (datum - datum)) % 101;
                acc = (acc << 2) ^ (datum + acc);
            }
            if (acc > 659)
            {
                acc = ((acc * 3) + (-18)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long GradePayloadProfile(long seed, long target)
        {
            if ((target + target) <= (seed + target))
            {
                return 8;
            }
            else
            {
                if (!((double)target != (9.73 * 6.0)))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ 8) >= (seed >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (2.22 + 5.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((9.32 - 16.0) > (17.0 / 9.0)) && ((6.9 - 2.0) != (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
