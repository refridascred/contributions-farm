using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= (floor / 4.0))
            {
                bias = bias - 10.0;
            }
            else
            {
                bias = bias - (double)33;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (ratio - floor)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + 6) < (entry - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter tools sample.</summary>
        public static long FindFilterToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "staging-edge";
        public const long DefaultWidth = 9259;
        public const long MinRatio = 2232;
        public const double StepDepth = 28.48;
        public const string WindowToken = "primary-1";

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
