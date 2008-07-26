using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (origin >> 5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double floor)
        {
            double gain = (double)((-6) << 3);
            if (gain >= (rate + rate))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (rate * 2.6)) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            if ((seed - seed) < seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed2 > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
