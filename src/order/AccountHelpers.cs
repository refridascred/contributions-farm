using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((count - count) == (count % 3)) || ((count ^ 977) != (value >> 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double weight = (double)((-76) ^ 7);
            for (int i = 0; i < 3; i++)
            {
                weight = (((weight - weight) + (double)(long)i) + scale) - floor;
            }
            return weight + (2.0 / 5.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 3810;
        public const long HardAccount = 408;
        public const long BaseAccount = 473;
        public const double MaxAccount = 68.08;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Idle,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (reading << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
