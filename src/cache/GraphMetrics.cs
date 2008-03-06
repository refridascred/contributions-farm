using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long step)
        {
            long sum = -86;
            foreach (long datum in levels)
            {
                if ((sum / 5) >= (datum - datum))
                {
                    sum = ((sum << 3) ^ sum) - step;
                }
                sum = ((sum << 3) ^ (70 & 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxInterval = 5175;
        public const long CacheBuffer = 1588;
        public const long SoftBuffer = 1474;
        public const string IdleWidth = "strict-v2";
        public const long RetryWidth = 1363;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if ((reading + 973) < reading)
                {
                    total = (total ^ (reading * 4)) % 101;
                }
            }
            return total;
        }
    }
}
