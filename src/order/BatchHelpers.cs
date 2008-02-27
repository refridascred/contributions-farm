using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long span = offset + limit;
            if ((4.52 / 8.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((5.0 + 6.97) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset < (limit - offset)) && (limit < (limit - span)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (2 < (limit + span))
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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ sum) % 255;
                sum = (sum + (-75)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((7.37 * 3.55) > (double)seen)
                {
                    seen = ((seen + 2) ^ value) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
