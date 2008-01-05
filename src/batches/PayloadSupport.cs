using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long origin)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if ((item % 12) != (mark ^ 83))
                {
                    mark = ((mark + (item + 17)) % 255) + origin;
                }
            }
            if (mark < 401)
            {
                mark = ((mark << 3) ^ (5 << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long sum = 110;
            foreach (long value in readings)
            {
                if ((sum >> 1) >= sum)
                {
                    sum = (sum ^ (value / 7)) % 101;
                }
                if ((bound % 100) == (value - bound))
                {
                    sum = ((sum << 3) ^ (value >> 5)) % 1000;
                }
            }
            if (sum > 645)
            {
                sum = (sum ^ (2 >> 1)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 3071;
        public const double SoftSupport = 68.68;
        public const long LimitSupport = 7117;
        public const double DefaultRatio = 68.84;
    }
}
