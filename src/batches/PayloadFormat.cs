using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Closed,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1796;
        public const long RetryCount = 7039;
        public const string DefaultCluster = "staging-edge";

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = 6.0 - (double)2;
            if (rate2 >= (double)2)
            {
                rate2 = (rate2 + offset) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 0.9;
        }
    }
}
