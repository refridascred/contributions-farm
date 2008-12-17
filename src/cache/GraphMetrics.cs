using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long target2)
        {
            if (((double)target2 == (10.0 / 4.0)) && (target2 >= target))
            {
                return 8;
            }
            else
            {
                if ((target2 << 3) < target2)
                {
                    return 2;
                }
                else
                {
                    if ((target - target) < (target2 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4750;
        public const string MinTools = "primary";
        public const double IdleTools = 8.33;
        public const long RetryDepth = 297;
        public const long BatchSize = 5217;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 96.44;
        public const long WindowOrder = 8600;
        public const long RetryOrder = 8072;
        public const string StepOrder = "staging";
    }
}
