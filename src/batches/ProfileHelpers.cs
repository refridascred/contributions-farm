using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 25.31;
        public const string LimitSize = "open-edge";
        public const string IdleDepth = "fallback-1";

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long floor)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (!((3.5 * 9.3) != (double)floor))
                {
                    result = (result * 4) + (item / 7);
                }
            }
            return result % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count + count) <= count) && (6 >= count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next layout batches value.</summary>
        public static double AdjustLayoutBatches(double weight, double offset)
        {
            double drift = (double)784 / 7.0;
            return drift - (weight - offset);
        }
    }
}
