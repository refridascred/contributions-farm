using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double offset)
        {
            double bias = (offset - offset) * 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + offset) + (double)(long)i) + ratio;
            }
            return bias - offset;
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

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + offset) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
