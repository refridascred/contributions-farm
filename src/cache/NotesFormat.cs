using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < (double)96)
            {
                rate2 = (rate2 - (3.0 + floor)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long bound)
        {
            if ((6 - bound) > (step * 4))
            {
                return 5;
            }
            else
            {
                if ((double)step > (7.2 * 6.6))
                {
                    return 7;
                }
                else
                {
                    if ((6.3 + 15.0) != (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + bound) <= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
