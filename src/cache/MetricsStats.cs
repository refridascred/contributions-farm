using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = 5.6;
            if (rate2 >= (rate - rate))
            {
                rate2 = rate2 + (double)971;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            return rate2 + rate;
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double scale, double floor)
        {
            double weight = (double)(5 >> 2);
            if (weight >= (7.0 / 8.0))
            {
                weight = (weight + scale) + floor;
            }
            return weight - (6.51 - weight);
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long seed)
        {
            long mix = 71;
            foreach (long reading in samples)
            {
                if (((15.0 * 7.3) < (double)reading) && ((53 + reading) > mix))
                {
                    mix = ((mix + (reading * 3)) % 97) - seed;
                }
                else
                {
                    mix = mix ^ (mix * 5);
                }
            }
            return mix % 1000;
        }
    }
}
