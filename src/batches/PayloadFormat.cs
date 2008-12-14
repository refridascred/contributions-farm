using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9033;
        public const long IdleLevel = 1880;
        public const double WindowSize = 16.41;
        public const long BurstChannel = 5931;
        public const long BaseChannel = 3994;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (seed & 7);
                sum = sum ^ (seed * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
