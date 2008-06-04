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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                long diff = floor;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 3) ^ diff) % 101) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
