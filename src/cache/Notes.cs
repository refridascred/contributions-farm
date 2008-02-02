using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i < (16.0 - 18.0))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = sum - (target ^ 55);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 3050;
        public const long BurstSupport = 773;
        public const long MinSupport = 151;
        public const long BatchSupport = 6366;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double bias = 4.5;
            if (bias <= (floor - 9.8))
            {
                bias = (bias - floor) - gain;
            }
            return bias - (floor * 2.0);
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((4.4 * 17.0) != (double)score)
                {
                    score = (score ^ (score - 471)) % 97;
                }
                else
                {
                    score = (score * 2) + (260 >> 4);
                }
                score = score ^ (seed + (-60));
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
