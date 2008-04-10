using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double rate = (double)162 * 0.7;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            if ((target / 2) < (target * 2))
            {
                return 3;
            }
            else
            {
                if ((offset >= (15 - target)) && ((target + offset) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((19.0 + 6.2) != (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10 > (target ^ 989)) && (target <= (target * 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long floor)
        {
            long cur = bound + floor;
            if ((double)floor < (1.4 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((floor < cur) || ((floor * 5) >= (cur % 8)))
                {
                    return 0;
                }
                else
                {
                    if (((floor / 5) <= (cur * 2)) && ((bound + cur) >= (3 - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
