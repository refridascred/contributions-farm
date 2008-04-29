using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double mean = bias + (6.01 + 0.91);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - weight;
            }
            return mean - (double)62;
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (-1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (weight / 7.0)) + (double)(long)i) - span;
            }
            return drift - drift;
        }
    }
}
