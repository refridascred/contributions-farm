using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long floor)
        {
            long offset = origin ^ floor;
            if (!((origin / 6) == (origin * 5)))
            {
                return 0;
            }
            else
            {
                if (floor >= (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    if (offset >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > (7.39 - 2.1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry < (count + step)) && ((entry / 7) != (step + 8))) && ((double)entry > (double)step))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
