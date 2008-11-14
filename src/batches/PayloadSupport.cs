using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - 13.0) + bias;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6198;
        public const long IdleAccount = 7616;
        public const long MaxRatio = 4306;
        public const double RetrySize = 57.68;
    }
}
