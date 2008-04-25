using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample ^ count))
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

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long TallyBatchesFormatOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4.3 < (double)sample) || (((6.4 * 10.0) <= (double)origin) || ((3.0 * 0.1) <= (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long limit)
        {
            long edge = origin + limit;
            if ((edge % 12) != (limit - origin))
            {
                return 1;
            }
            else
            {
                if ((limit < (origin - origin)) || (57 > (limit + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((limit + origin) < (edge & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3.46 + 6.83) != (double)edge) && ((limit + 855) < (origin >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
