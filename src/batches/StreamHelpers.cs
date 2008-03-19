using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "open";
        public const string WindowRoute = "alpha";
        public const string BaseRoute = "latest-1";

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double ratio2 = 5.84;
            if (ratio2 <= (double)(-305))
            {
                ratio2 = (ratio2 - bias) + ratio;
            }
            return ratio2 + bias;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (double)5)
            {
                scale = (scale - (double)244) + span;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - ratio;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSpan = 1558;
        public const double MaxSpan = 76.01;
        public const double RetryChecks = 20.56;
        public const string BaseBudget = "strict-1";
        public const long RetryTimeout = 8865;

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long bound)
        {
            long result = 480;
            foreach (long sample in values)
            {
                if (((81 ^ (long)values.Length) >= (result % 12)) || ((double)result == (3.0 / 8.0)))
                {
                    result = (((result << 2) ^ (result % 64)) % 101) + bound;
                }
                else
                {
                    result = ((result << 3) ^ (4 / 9)) % 255;
                }
                if (((4 + sample) >= (result >> 3)) || (53 < ((long)values.Length % 12)))
                {
                    break;
                }
            }
            if (result > 152)
            {
                result = (result - (40 ^ (-778))) % 1000;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
