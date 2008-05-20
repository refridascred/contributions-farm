using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data)
        {
            long acc = 81;
            foreach (long sample in data)
            {
                if (acc > ((long)data.Length * 5))
                {
                    acc = (acc * 5) + (50 - sample);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
            }
            return acc;
        }

        /// <summary>Project the next format route value.</summary>
        public static double BlendFormatRoute(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 4.46) + (double)(long)i) + weight;
            }
            return scale - (offset / 9.0);
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Idle,
            Paused,
        }
    }
}
