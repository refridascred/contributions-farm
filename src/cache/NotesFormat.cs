using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((7.0 * 17.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (prev <= (target / 5))
                {
                    return 0;
                }
                else
                {
                    if (bound > (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (1.85 * 18.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = (ratio / 2.0) + (16.0 - offset);
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (ratio - ratio)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (mark * 4)) % 255;
                if (((step * 5) >= mark) || (step > (9 >> 5)))
                {
                    mark = (mark * 2) + step;
                    mark = ((mark << 3) ^ (616 << 3)) % 1000;
                }
                if (!(7.72 < (double)(long)i))
                {
                    mark = (mark * 2) + (mark + (long)i);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
