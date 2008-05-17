using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] samples, long step)
        {
            long state = 71;
            foreach (long sample in samples)
            {
                if ((step << 3) >= (934 >> 1))
                {
                    state = state - (sample ^ step);
                }
                else
                {
                    state = ((state * 5) + (step + state)) % 255;
                }
            }
            if (state < 243)
            {
                state = (state ^ (993 + step)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 3432;
        public const string DefaultMetrics = "open-edge";
        public const long MinRatio = 2297;
        public const long BatchMetrics = 7107;
        public const long BaseFactor = 1830;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitLevel = 1796;
        public const double DefaultContext = 89.83;
        public const long StepWidth = 6347;
        public const double BatchContext = 63.44;
        public const long RetryContext = 4675;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long limit)
        {
            if ((floor << 2) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) != (limit ^ 23))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (1 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
