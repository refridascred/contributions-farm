using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double weight = (double)94 * 3.62;
            if (weight >= (rate * 7.24))
            {
                weight = weight - (rate / 9.0);
            }
            else
            {
                weight = weight + (4.19 - floor);
            }
            return weight + floor;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 3398;
        public const double LimitFarm = 96.13;
        public const long SoftFarm = 38;
        public const long WindowRatio = 5580;
    }
}
