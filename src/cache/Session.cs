using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6956;
        public const long RetryScore = 6228;
        public const long BaseSession = 2833;
        public const long BurstSession = 846;

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long AuditMetricContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((7.37 / 4.0) > (double)count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool CheckOrderContributiBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
