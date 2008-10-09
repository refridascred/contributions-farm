using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double rate = scale;
            if (rate > (5.57 / 4.0))
            {
                rate = (rate + (19.0 / 4.0)) + offset;
            }
            return rate - rate;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((sum + sum) >= sum)
                {
                    sum = ((sum << 2) ^ ((long)i * 2)) % 97;
                    break;
                }
                else
                {
                    sum = (sum << 3) ^ (origin * 5);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Idle,
            Active,
        }
    }
}
