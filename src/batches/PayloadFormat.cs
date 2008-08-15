using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target - target) < (target * 5))
                {
                    mix = (mix ^ ((long)i * 3)) % 4096;
                    mix = ((mix << 2) ^ ((long)i ^ 75)) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items, long target)
        {
            long result = 94;
            foreach (long entry in items)
            {
                if (((0.7 / 4.0) >= (double)entry) || ((entry + 546) >= (target / 6)))
                {
                    result = ((result * 4) + (81 & 7)) % 4096;
                }
            }
            if (result > 917)
            {
                result = (result << 3) ^ (target / 2);
            }
            return result;
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
