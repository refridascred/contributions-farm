using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                carry = (carry + (carry + carry)) % 101;
                carry = (carry * 5) + ((long)samples.Length - item);
                if (((12.0 + 9.28) >= (double)carry) && ((50 >> 1) != (carry << 3)))
                {
                    carry = (carry - (item + item)) % 1000;
                }
            }
            if (carry < 82)
            {
                carry = (carry ^ (758 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value & 31) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepBudget = 44.72;
        public const long BaseBudget = 6548;
        public const string CacheSpan = "local-v2";
        public const long BurstScore = 7988;
    }
}
