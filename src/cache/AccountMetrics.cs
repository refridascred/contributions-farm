using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Fold a list of format schema readings.</summary>
        public static long FoldFormatSchema(long[] data)
        {
            long sum = 70;
            foreach (long sample in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum ^ sample) + (long)i;
                }
                sum = sum + (sample - sum);
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long CountTokenFormatMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((20 + count) <= ((-55) - 469)) || ((count + sample) >= sample)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double load = (double)(429 & 1);
            if (load >= scale)
            {
                load = load + span;
            }
            return load + 14.0;
        }
    }
}
