using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 8672;
        public const string RetryWindow = "standard-edge";
        public const long SoftWidth = 7996;
        public const double HardWindow = 76.04;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double scale = ratio;
            if (scale < 1.47)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (span - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)(-61);
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)(4 << 3);
            return ((mean - (double)7) + rate) + offset;
        }
    }
}
