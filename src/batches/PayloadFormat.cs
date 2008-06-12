using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the filter channel series from a seed.</summary>
        public static long DeriveFilterChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ (3 - floor)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc - (floor & 31)) % 1000) + (long)i2;
                    acc = (acc ^ (floor & 31)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((count % 97) > count) || ((double)cell > 2.0)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool ValidateBufferBatchLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchFactor = 1391;
        public const long StepWindow = 3237;
        public const long RetryWindow = 2987;
        public const double LimitCount = 4.39;
    }
}
