using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long offset)
        {
            long edge = step - offset;
            if ((9 / 2) < (step % 7))
            {
                return 3;
            }
            else
            {
                if ((double)edge <= (5.95 - 19.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = span / 5.0;
            if (rate < rate)
            {
                rate = (rate - rate) + ratio;
            }
            return rate - (double)966;
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long MeasureAccountGraphOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (4.6 + 12.0))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long sum = 705;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ reading) % 65521;
            }
            return sum % 65521;
        }
    }
}
