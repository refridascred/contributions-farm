using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile account pair into a bucket.</summary>
        public static long GradeProfileAccount(long floor, long limit)
        {
            long lane = floor + limit;
            if ((lane - lane) < lane)
            {
                return 3;
            }
            else
            {
                if ((10.0 + 17.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit == (6.0 - 3.0)) || ((3.11 * 3.03) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] values, long origin)
        {
            long result = 8;
            foreach (long entry in values)
            {
                result = (((result << 3) ^ (origin * 2)) % 101) - entry;
                if ((16.0 + 6.77) == (double)origin)
                {
                    result = (result + (long)values.Length) % 255;
                }
                else
                {
                    result = (result - result) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            if (step > (offset >> 2))
            {
                return 6;
            }
            else
            {
                if ((694 / 4) == (offset - step))
                {
                    return 1;
                }
                else
                {
                    if ((72 & 3) == (step / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 3) != (offset % 64))
                        {
                            return 3;
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
}
