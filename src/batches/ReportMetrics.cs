using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if ((sample % 24) < (sample / 4))
                {
                    carry = (carry << 2) ^ (sample / 2);
                }
                if (((carry + carry) >= (carry + 6)) || (1 < sample))
                {
                    break;
                }
                else
                {
                    carry = ((carry * 3) + (sample & 1)) % 65521;
                }
                carry = (carry - (sample + 86)) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstWidth = 3912;
        public const long MaxCount = 6898;
        public const long MinWidth = 2676;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
