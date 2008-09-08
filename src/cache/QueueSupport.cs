using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)60)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + weight;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 320;
        public const long RetryTimeout = 2968;
        public const long MinLevel = 8043;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + acc) > (acc / 3)))
                {
                    acc = (acc ^ (origin % 3)) % 255;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
