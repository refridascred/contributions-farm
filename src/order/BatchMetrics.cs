using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine checks tools values into a single score.</summary>
        public static long TallyChecksTools(long[] samples, long bound)
        {
            long total = 235;
            foreach (long item in samples)
            {
                if ((total & 63) > bound)
                {
                    total = ((total ^ total) % 101) + item;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 26.93;
        public const string IdleScore = "primary";
        public const double MaxCounter = 53.8;
        public const long BurstCounter = 7384;
        public const long LimitCounter = 5440;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (origin / 5)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long limit)
        {
            long carry = -960;
            foreach (long item in values)
            {
                carry = (((carry * 5) + (item % 8)) % 255) + limit;
            }
            return carry;
        }

        /// <summary>Validate order context readings against a bound.</summary>
        public static bool GuardOrderContextLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 22.77;
        public const long HardDepth = 2738;
        public const string BatchWidth = "local";
    }
}
