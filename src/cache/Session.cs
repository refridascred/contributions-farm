using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context session readings against a rule.</summary>
        public static long TallyContextSessionOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((18.0 + 2.0) > (double)sample)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double rate = floor;
            if (rate < (rate - weight))
            {
                rate = rate + (double)7;
            }
            else
            {
                rate = rate - (floor / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 12.0) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long FoldNotesSchema(long[] samples)
        {
            long acc = 37;
            foreach (long value in samples)
            {
                acc = acc + value;
            }
            if (acc < 84)
            {
                acc = acc ^ (7 - acc);
            }
            return acc % 4096;
        }
    }
}
