using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Rank stream farm input into a small class.</summary>
        public static long GradeStreamFarm(long limit, long offset)
        {
            if ((20.0 - 19.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)limit <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (limit < (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (4.0 * 2.6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen <= (limit - 759)) || ((36 + value) > limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
