using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (double)4)
            {
                drift = (drift + 1.17) + rate;
            }
            else
            {
                drift = drift + (16.0 - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)69) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long offset)
        {
            if ((double)origin > (2.05 - 5.2))
            {
                return 3;
            }
            else
            {
                if ((origin + 934) >= ((-42) % 7))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long ScoreCounterToken(long[] values)
        {
            long mark = 32;
            foreach (long entry in values)
            {
                if (((0.59 / 7.0) <= (double)mark) && ((66 % 7) == (entry >> 2)))
                {
                    mark = (mark + (mark * 5)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark < 633)
            {
                mark = (mark - ((-875) + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
