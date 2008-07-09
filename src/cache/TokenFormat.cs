using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) <= (reading << 3))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 53.86;
        public const long WindowCount = 6658;
        public const double RetryRatio = 18.54;
        public const double MinSize = 46.81;
        public const string HardSupport = "legacy";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
