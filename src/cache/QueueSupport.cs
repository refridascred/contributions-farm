using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metric tools readings against a rule.</summary>
        public static long TallyMetricToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((9 - 2) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)(long)i) - bias;
            }
            return rate + 4.8;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)81;
            if (scale < (double)498)
            {
                scale = (scale + (double)40) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (bias2 * 3.31)) + (double)(long)i;
            }
            return scale + (double)98;
        }
    }
}
