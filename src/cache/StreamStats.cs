using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = 19;
            foreach (long datum in values)
            {
                if ((sum >> 5) != (datum % 16))
                {
                    sum = (sum << 3) ^ 73;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long StepClusterTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (83 <= (seed + 3))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two token filter measurements.</summary>
        public static double ProjectTokenFilter(double weight, double floor)
        {
            double rate = floor;
            if (rate > (rate - 6.4))
            {
                rate = (rate + 4.17) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate * 2.1)) + (double)(long)i;
            }
            return rate + (2.0 / 5.0);
        }
    }
}
