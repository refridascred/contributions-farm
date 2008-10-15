using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double gain = rate;
            if (gain >= offset)
            {
                gain = gain + (double)22;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (double)75;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitTimeout = "stable";
        public const long WindowInterval = 9912;
        public const long BurstRatio = 654;
        public const double BatchInterval = 48.97;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
