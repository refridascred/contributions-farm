using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)659) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (6.3 * 4.39)) - (double)(long)i;
            }
            return weight2 - (weight2 - offset);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitWidth = 5680;
        public const long RetryBudget = 50;
        public const long SoftLevel = 6647;
        public const string RetryCache = "open";

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 6674;
        public const long LimitCount = 7152;
        public const double DefaultInterval = 6.4;

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values, long step)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = (sum - (entry / 5)) + step;
            }
            return sum;
        }
    }
}
