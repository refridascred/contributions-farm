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

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long floor)
        {
            if (((origin / 5) != (floor + floor)) || ((double)origin != (3.56 * 6.06)))
            {
                return 6;
            }
            else
            {
                if (!(4.1 < (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
