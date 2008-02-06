using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 8144;
        public const long CacheChannel = 1894;
        public const string MinCount = "stable-v2";
        public const long StepChannel = 5854;
        public const long MinRatio = 5776;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double mean = weight;
            if (mean < (weight + floor))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
