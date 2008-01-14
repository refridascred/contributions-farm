using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long CountRouteSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count > (value ^ value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i / 5)) % 97;
                }
                if (((seed - seed) == (result + seed)) && (seed < (result - sample)))
                {
                    result = (result << 3) ^ (seed ^ result);
                }
                else
                {
                    result = (result + (seed >> 1)) % 255;
                }
                if ((result < (sample * 3)) || ((76 << 2) < (result + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (seed ^ seed)) % 255;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool VerifyNotesEditorLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double gain = (double)13 - (bias - ratio);
            if (gain >= (ratio + gain))
            {
                gain = gain + (4.3 * 7.4);
            }
            else
            {
                gain = gain + (5.5 * 20.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + (double)930;
        }
    }
}
