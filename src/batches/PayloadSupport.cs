using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7191;
        public const long WindowBatches = 7442;
        public const long BaseWidth = 1053;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (floor >= (count + (-2)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double weight = scale * 3.0;
            if (weight > weight)
            {
                weight = weight - (weight + 15.0);
            }
            return weight + span;
        }
    }
}
