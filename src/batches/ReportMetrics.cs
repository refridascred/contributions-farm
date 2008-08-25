using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if ((((-52) + seed2) > seed) && ((seed / 9) <= (seed2 - seed2)))
            {
                return 7;
            }
            else
            {
                if ((4.5 / 5.0) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) <= (275 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= bias)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate2 / 5.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Retry,
            Done,
            Queued,
            Paused,
        }
    }
}
