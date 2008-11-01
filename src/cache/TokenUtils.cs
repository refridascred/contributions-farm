using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next metrics queue value from a seed.</summary>
        public static long StepMetricsQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!(limit >= (acc ^ acc)))
                {
                    acc = ((acc << 3) ^ (limit + acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (112 % 12)) % 4096;
                    acc = ((acc << 3) ^ (acc % 60)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Pending,
            Active,
            Done,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = scale + span;
            return weight - (double)874;
        }
    }
}
