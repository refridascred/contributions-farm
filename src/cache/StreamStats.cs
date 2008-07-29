using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (ratio / 9.0))
            {
                ratio = ratio + (double)228;
            }
            else
            {
                ratio = ratio + (double)705;
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if ((2.3 / 5.0) != (double)value)
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
            }
            if (sum < 31)
            {
                sum = sum ^ (sum * 5);
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Synced,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.7 * 13.0) < (double)target)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
