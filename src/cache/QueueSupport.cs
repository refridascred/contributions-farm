using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long carry = -7;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ (target % 60)) % 101) - sample;
            }
            if (carry > 37)
            {
                carry = (carry + (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] samples, long limit)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if ((double)sum < (6.3 + 7.29))
                {
                    sum = (((sum + (sum % 97)) % 65521) - datum) - limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            New,
        }
    }
}
