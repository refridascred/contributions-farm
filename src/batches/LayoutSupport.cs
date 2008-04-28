using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseCount = "standard-edge";
        public const long WindowTimeout = 4524;
        public const string WindowStats = "standard-v2";

        /// <summary>Adjust a stream window reading.</summary>
        public static double BlendStreamWindow(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (bias * 3.97))
            {
                bias = bias + (2.7 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.8 + 5.1) < (double)seed)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if (((-8) & 15) >= floor)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((result + sample) >= 453)
                {
                    result = ((result << 2) ^ sample) % 65521;
                }
                result = (result - (sample - result)) % 4096;
                if (((sample + 11) < 417) || (result <= (result * 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
