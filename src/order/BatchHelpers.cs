using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long step)
        {
            if (origin >= ((-30) >> 1))
            {
                return 0;
            }
            else
            {
                if (((double)176 == (double)origin) && ((origin * 2) > (178 * 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin < (5.65 / 9.0)))
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

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double rate, double offset)
        {
            double drift = rate;
            if (drift > (7.34 * 3.5))
            {
                drift = (drift - (rate * 1.2)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (7.8 + 5.0)) + (double)(long)i;
            }
            return drift - (double)182;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Draft,
            Active,
            Retry,
            Done,
        }
    }
}
