using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + count) >= (reading * 2)) && ((reading % 24) == (reading & 255)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double weight = (bias * 7.78) / 8.0;
            return (weight - bias) + ratio;
        }

        /// <summary>Grade a cache batch value against two limits.</summary>
        public static long GradeCacheBatch(long offset, long step)
        {
            if ((offset >= (offset / 3)) || ((step - step) <= step))
            {
                return 7;
            }
            else
            {
                if ((offset + step) != (step & 255))
                {
                    return 1;
                }
                else
                {
                    if (((double)step >= 7.9) && ((0.33 - 5.69) < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= offset) && ((double)offset == (5.94 - 5.79)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
