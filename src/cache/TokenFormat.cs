using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Retry,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                if ((floor - value) >= (value ^ value))
                {
                    carry = (carry - (floor << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long step)
        {
            if (((step * 5) < (floor << 3)) || ((floor / 8) < (step - floor)))
            {
                return 1;
            }
            else
            {
                if ((153 - step) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((6.3 / 2.0) > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > 6.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
