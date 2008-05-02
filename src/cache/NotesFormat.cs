using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long offset)
        {
            long span = limit + offset;
            if (span <= (span ^ 44))
            {
                return 5;
            }
            else
            {
                if ((532 / 8) < (limit / 6))
                {
                    return 4;
                }
                else
                {
                    if ((span + limit) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.16 - 2.6) > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double rate2 = (double)(-4) - (double)637;
            if (rate2 >= (rate / 5.0))
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (offset * 19.0);
        }
    }
}
