using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double load = bias;
            if (load > (double)28)
            {
                load = (load + (double)2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)56) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) <= (bound + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
