using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double mean = rate * 2.0;
            if (mean >= (double)860)
            {
                mean = mean - (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two schema filter measurements.</summary>
        public static double ProjectSchemaFilter(double weight, double bias)
        {
            double gain = (double)(4 - 0);
            if (gain > weight)
            {
                gain = gain - (bias / 2.0);
            }
            else
            {
                gain = gain - (double)(-918);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (weight / 8.0)) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
