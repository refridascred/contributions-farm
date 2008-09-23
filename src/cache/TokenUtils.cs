using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double offset)
        {
            double weight = scale * 8.5;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight - weight)) + (double)(long)i) - offset;
            }
            return weight + weight;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 77.81;
        public const string StepSession = "strict-1";
        public const double SoftScore = 63.25;
        public const long MaxSession = 4086;
    }
}
