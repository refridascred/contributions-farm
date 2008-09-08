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

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 2128;
        public const long StepInterval = 5658;
        public const long SoftSpan = 5937;
        public const double IdleAlready = 89.19;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
