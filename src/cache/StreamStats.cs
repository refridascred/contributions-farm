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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
