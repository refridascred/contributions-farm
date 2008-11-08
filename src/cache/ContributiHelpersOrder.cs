using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long carry = 27;
            foreach (long reading in readings)
            {
                if ((4.89 + 1.6) == (double)reading)
                {
                    carry = carry ^ (carry * 2);
                }
                else
                {
                    carry = (carry - carry) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 3) + (mark * 3);
                if (mark >= 19)
                {
                    mark = (mark ^ (origin >> 3)) % 255;
                    break;
                }
                if ((5.74 / 8.0) <= (double)origin)
                {
                    long delta = mark * 4;
                    mark = (mark ^ (origin - delta)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
