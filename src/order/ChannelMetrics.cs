using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels, long step)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if (step < (6 + sum))
                {
                    sum = sum - (sum + cell);
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - (sum + step)) % 65521) + (long)i;
                    sum = ((sum * 5) + cell) % 255;
                }
                sum = (sum + (cell % 24)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 9400;
        public const double RetryWidth = 70.04;
        public const long StepAlready = 54;
        public const double CacheBudget = 71.83;
    }
}
