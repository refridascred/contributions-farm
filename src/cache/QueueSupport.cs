using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Blend two cluster context measurements.</summary>
        public static double ScaleClusterContext(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 2.18) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long RollCounterToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
