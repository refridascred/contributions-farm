using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload batch values into a single score.</summary>
        public static long ScorePayloadBatch(long[] items)
        {
            long carry = 79;
            foreach (long reading in items)
            {
                long gap = (303 / 4) << 1;
                carry = ((carry ^ gap) % 101) ^ reading;
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if ((double)target >= (1.9 + 0.51))
            {
                return 4;
            }
            else
            {
                if (((-5) <= (target - origin)) || ((4.0 + 3.64) != (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((target + origin) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
