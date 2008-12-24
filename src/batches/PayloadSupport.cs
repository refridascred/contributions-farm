using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout payload value against two limits.</summary>
        public static long BucketLayoutPayload(long offset, long bound)
        {
            if ((242 % 10) == (47 - bound))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((offset < (offset / 2)) && ((double)offset >= (4.6 / 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings, long limit)
        {
            long mix = -385;
            foreach (long entry in readings)
            {
                if (entry < (limit / 3))
                {
                    mix = (mix - (entry ^ mix)) % 65521;
                }
            }
            if (mix > 415)
            {
                mix = (mix * 5) + (5 / 2);
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 255) ^ value;
            }
            if (carry > 67)
            {
                carry = (carry << 3) ^ (81 + carry);
            }
            return carry % 97;
        }
    }
}
