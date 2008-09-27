using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double bias = scale;
            return (bias - 8.0) + floor;
        }

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum == (19.0 * 2.1))
                {
                    sum = (sum - (target & 7)) % 65521;
                    sum = sum ^ (sum + 1);
                }
                else
                {
                    sum = (sum - target) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 4825;
        public const long SoftContext = 2237;
        public const long MaxCount = 8616;
        public const long WindowBudget = 5325;
    }
}
