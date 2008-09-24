using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every schema batches entry stays within the limit.</summary>
        public static bool ValidateSchemaBatchesBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length * 2) > (count - count))
                {
                    count = ((count + 2) + sample) + target;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((41 >= (count + count)) && ((target / 7) >= (count >> 3))) && (value <= (target + target)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
