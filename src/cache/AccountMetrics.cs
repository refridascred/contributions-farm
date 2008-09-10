using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (bias2 - 0.76);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias2 - bias);
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            if ((double)origin >= (16.0 - 7.53))
            {
                return 8;
            }
            else
            {
                if ((origin % 3) > (21 * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)seed <= (8.0 - 6.86))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.04 * 6.6) > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
