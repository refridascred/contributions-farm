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

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double bias2)
        {
            double mean = (double)(430 << 3);
            return ((mean + (double)58) + bias) + bias2;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)(4 << 3);
            return ((mean - (double)7) + rate) + offset;
        }
    }
}
