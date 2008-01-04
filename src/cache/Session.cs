using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] levels)
        {
            long sum = 363;
            foreach (long datum in levels)
            {
                if ((sum * 5) == (4 + 8))
                {
                    sum = ((sum * 5) + 54) % 4096;
                }
                else
                {
                    sum = sum - ((long)levels.Length + sum);
                }
                if (((datum / 6) != (datum & 7)) && ((sum / 8) <= (sum + sum)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)4)
            {
                bias = bias - offset;
            }
            return bias - 2.8;
        }
    }
}
