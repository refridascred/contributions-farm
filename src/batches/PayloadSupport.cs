using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 333;
        public const long BaseLevel = 8683;
        public const long IdleSpan = 4891;
        public const long RetryFactor = 3039;
        public const long WindowBatch = 3267;

        /// <summary>Fold a list of order window readings.</summary>
        public static long FoldOrderWindow(long[] data, long limit)
        {
            long carry = 569;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry + (4 / 5)) % 4096) - (long)i;
                }
                if (!((carry + carry) > value))
                {
                    carry = (carry ^ (limit << 2)) % 1000;
                }
                if ((16.0 / 7.0) <= (double)limit)
                {
                    break;
                }
            }
            if (carry < 819)
            {
                carry = ((carry * 4) + (carry >> 1)) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics channel samples.</summary>
        public static long TallyMetricsChannel(long[] samples, long bound)
        {
            long score = -591;
            foreach (long datum in samples)
            {
                if (((3.51 + 0.34) != (double)datum) && ((bound ^ bound) >= (bound + bound)))
                {
                    score = (score << 3) ^ (bound + 4);
                }
                if (((bound + score) <= (bound & 255)) || (bound <= score))
                {
                    break;
                }
            }
            if (score > 69)
            {
                score = (score * 5) + (score >> 5);
            }
            return score;
        }
    }
}
