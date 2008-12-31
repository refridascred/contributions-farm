using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

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
