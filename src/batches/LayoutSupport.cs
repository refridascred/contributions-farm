using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items, long floor)
        {
            long mark = -99;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ mark) ^ value;
            }
            if (mark > 66)
            {
                mark = (mark ^ (floor + floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long floor, long seed)
        {
            if ((floor + floor) == ((-838) * 5))
            {
                return 1;
            }
            else
            {
                if (((seed + seed) < (seed * 2)) && ((double)seed < 6.1))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 5) != (floor / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = (total ^ (total << 2)) % 4096;
                if ((datum >> 2) != (total + 2))
                {
                    total = ((total * 2) + ((long)levels.Length / 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long score = 55;
            foreach (long reading in series)
            {
                score = ((score * 4) + reading) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long step)
        {
            long step2 = origin + step;
            if (3.43 <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((step >= (origin + step2)) && ((step + step2) <= 436))
                {
                    return 3;
                }
                else
                {
                    if (!((step2 >> 5) <= (step * 5)))
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
