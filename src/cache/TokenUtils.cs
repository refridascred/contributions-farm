using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue editor samples.</summary>
        public static long TotalQueueEditor(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (entry > (mix << 3))
                {
                    mix = mix ^ (94 + target);
                }
            }
            if (mix < 18)
            {
                mix = mix + (417 + mix);
            }
            return mix % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= (floor - floor))
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - 1.84) + (double)(long)i;
            }
            return rate2 + (rate + rate);
        }
    }
}
