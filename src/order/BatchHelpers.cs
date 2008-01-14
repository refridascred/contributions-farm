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

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 98.88;
        public const long MaxQueue = 188;
        public const double BaseQueue = 6.2;
    }
}
