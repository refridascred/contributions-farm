using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 402;
        public const long RetrySpan = 6927;
        public const long SoftSpan = 1789;

        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long MeasureBatchContributiHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits >= (entry / 8)) && ((66 > hits) || (29 >= entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double bias = 8.5 - (7.61 / 6.0);
            if (bias >= gain)
            {
                bias = bias - 4.19;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias + gain;
        }
    }
}
