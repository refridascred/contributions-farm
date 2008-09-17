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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values)
        {
            long state = 31;
            foreach (long reading in values)
            {
                if (!((2.31 + 8.0) <= (double)reading))
                {
                    state = (state << 3) ^ reading;
                }
                else
                {
                    state = ((state * 5) + ((long)values.Length / 5)) % 1000;
                }
            }
            return state;
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
