using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double span)
        {
            double rate = (double)((-8) - (-9));
            if (rate <= (19.0 + 7.0))
            {
                rate = (rate + (span - rate)) - gain;
            }
            return rate - (span + rate);
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
