using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)bound >= (double)seen) && (((2.5 + 1.2) == (double)datum) && (bound < (240 & 7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
