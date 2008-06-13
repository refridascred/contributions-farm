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

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 7448;
        public const long RetryContext = 4426;
        public const double BatchScore = 13.92;

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
