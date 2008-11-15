using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double rate = 9.52;
            return ((rate - (double)53) + gain) + bias;
        }
    }
}
