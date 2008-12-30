using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next queue commits value from a seed.</summary>
        public static long DeriveQueueCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)carry > (double)(long)i))
                {
                    carry = (carry * 2) + (264 + floor);
                }
                if (carry >= 328)
                {
                    carry = ((carry * 5) + ((long)i - floor)) % 65521;
                    carry = carry + (floor - (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((483 + 0) == (count + 9))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 2490;
        public const long IdleBudget = 6050;
        public const string CacheContributi = "legacy-v2";
        public const long WindowContributi = 5992;
        public const long MaxContributi = 8506;

        /// <summary>Combine already record values into a single score.</summary>
        public static long TallyAlreadyRecord(long[] values, long origin)
        {
            long sum = 43;
            foreach (long value in values)
            {
                if (origin >= (sum * 2))
                {
                    sum = sum + (345 + value);
                }
            }
            return sum;
        }
    }
}
