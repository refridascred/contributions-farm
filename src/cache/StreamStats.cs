using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 7132;
        public const long WindowContext = 2015;
        public const string DefaultCount = "primary-1";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double bias = (double)(7 + 9);
            if (bias < span)
            {
                bias = (bias + (double)(-8)) - rate;
            }
            else
            {
                bias = bias - 20.0;
            }
            return bias - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "open";
        public const string LimitDepth = "strict-edge";
        public const double DefaultTimeout = 0.78;
    }
}
