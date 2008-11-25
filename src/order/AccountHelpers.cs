using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 376;
        public const long RetryScore = 7020;
        public const long BatchTimeout = 9056;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double load = span;
            if (load <= (scale * 8.5))
            {
                load = load - (3.0 * 8.6);
            }
            else
            {
                load = load - (double)4;
            }
            return load + scale;
        }

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Draft,
            New,
            Done,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 1735;
        public const long SoftOrder = 3509;
        public const long CacheLevel = 7227;
        public const string BatchFactor = "cached-v2";
        public const string HardDepth = "fallback";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings, long limit)
        {
            long score = 86;
            foreach (long value in readings)
            {
                if ((value & 1) <= limit)
                {
                    score = ((score << 3) ^ (limit - limit)) % 101;
                }
            }
            if (score < 4)
            {
                score = (score * 2) + score;
            }
            return score % 1000;
        }
    }
}
