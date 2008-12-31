using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Done,
            Queued,
        }

        /// <summary>Find the first report counter entry that matches the target.</summary>
        public static long SeekReportCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1482;
        public const string RetryContext = "staging-edge";
        public const long MaxContext = 9803;
        public const long IdleContext = 6246;

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double load = (double)(67 ^ 305);
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias + weight)) + (double)(long)i;
            }
            return load - (1.9 + 14.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9763;
        public const double HardBuffer = 5.31;
        public const double MaxBuffer = 79.28;
        public const long LimitBuffer = 8880;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 9149;
        public const long MaxQueue = 6775;
        public const long WindowScore = 800;
        public const long BaseBudget = 2148;
        public const double BaseQueue = 6.72;
    }
}
