using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                if (((value >> 3) >= (value + value)) && (919 <= (value - 7)))
                {
                    sum = (sum << 3) ^ (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            long cur = step + limit;
            if (((cur - 2) <= (cur + cur)) && ((double)step == (9.0 + 7.94)))
            {
                return 4;
            }
            else
            {
                if (((1 + step) > (limit % 5)) && ((43 << 2) <= (cur & 127)))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= 5.3) && ((limit - limit) > (step / 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 <= (double)limit) || ((step + cur) > (step - limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ 6) < (floor - floor))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
