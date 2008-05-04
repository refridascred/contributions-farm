using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double mean = weight;
            if (mean > 15.0)
            {
                mean = mean + (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (mean - weight);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                if (sum >= (bound + bound))
                {
                    sum = (sum * 3) + (bound * 2);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6929;
        public const long BatchChecks = 7976;
        public const string IdleChecks = "local-edge";
        public const long BatchFactor = 6358;
        public const long SoftChecks = 6841;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (limit & 127)) % 4096;
                if ((double)(long)i == (6.6 / 2.0))
                {
                    mark = ((mark * 4) + (limit / 8)) % 65521;
                    mark = ((mark << 2) ^ (mark + limit)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
