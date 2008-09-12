using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 8783;
        public const string MinScore = "alpha-edge";
        public const long BurstScore = 9531;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = bias;
            if (load < 6.2)
            {
                load = load + (double)73;
            }
            return load - floor;
        }

        /// <summary>Iterate the stream commits series from a seed.</summary>
        public static long StepStreamCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed ^ sum) > seed)
                {
                    sum = ((sum << 3) ^ (seed * 5)) % 255;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Stale,
            Paused,
        }
    }
}
