using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ ((long)i + target)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double ratio2 = ratio - (double)57;
            if (ratio2 > span)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (3.2 + ratio);
        }
    }
}
