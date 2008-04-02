using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 1163;
        public const double BatchPayload = 14.87;
        public const long CachePayload = 948;
        public const long StepPayload = 8701;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + (double)435) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
