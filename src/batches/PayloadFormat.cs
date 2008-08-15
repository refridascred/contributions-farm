using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double gain, double offset)
        {
            double rate = (gain / 8.0) - (double)3;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (5.0 + offset)) - (double)(long)i;
            }
            return rate + gain;
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
