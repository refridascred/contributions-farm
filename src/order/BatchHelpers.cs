using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if ((double)floor != (9.0 - 1.96))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) < (floor + limit))
                {
                    return 0;
                }
                else
                {
                    if (58 < (floor >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit & 1) >= (floor << 2)) || ((double)floor <= 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] values)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = ((result << 2) ^ 8) % 255;
                if ((result + reading) == (reading + (-66)))
                {
                    result = result - (result - reading);
                }
                else
                {
                    result = (result + result) % 65521;
                    result = (result - (501 << 2)) % 97;
                }
                if ((55 % 60) == (result * 5))
                {
                    result = (result - result) % 65521;
                }
            }
            return result % 97;
        }
    }
}
