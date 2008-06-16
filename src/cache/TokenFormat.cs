using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit - cur) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.3 / 6.0) != (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if ((double)mix <= (6.5 / 8.0))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + reading;
                }
            }
            return mix;
        }

        /// <summary>Check that every format counter entry stays within the limit.</summary>
        public static bool VerifyFormatCounterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
