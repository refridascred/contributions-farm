using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - (341 << 3)) % 1000) ^ (long)i2;
                }
                total = ((total << 3) ^ ((long)i << 1)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double weight2 = (double)(-8) * 8.14;
            return ((weight2 - (5.1 * 7.85)) + weight) + bias;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if ((step - 12) < (84 % 2))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) > (step + origin)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
