using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 1) >= (count >> 4))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool GuardOrderStatsBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long step)
        {
            long bound = target ^ step;
            if ((7.98 * 1.79) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((22 - step) < step) || ((step << 2) > (bound + target)))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long score = 6;
            foreach (long item in samples)
            {
                if (7.85 < (double)score)
                {
                    score = (score - (score + item)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double mean = (bias / 5.0) * 2.0;
            if (mean > bias)
            {
                mean = mean - 9.2;
            }
            return mean - floor;
        }
    }
}
