using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long floor2)
        {
            if ((floor - 740) == (floor2 / 2))
            {
                return 8;
            }
            else
            {
                if ((floor2 - 480) != (floor2 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 + 5.9) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor2 - 3) <= (51 % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = bias;
            if (gain <= ratio)
            {
                gain = gain + 2.0;
            }
            return gain - (double)(-1);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double drift = gain;
            return (drift - (gain / 9.0)) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "strict";
        public const long MinLevel = 705;
        public const long DefaultToken = 3446;
        public const string SoftToken = "legacy-1";
    }
}
