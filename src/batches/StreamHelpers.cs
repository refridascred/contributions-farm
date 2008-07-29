using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long carry = 68;
            foreach (long reading in data)
            {
                if (!((double)carry >= (double)reading))
                {
                    carry = (carry ^ ((long)data.Length ^ carry)) - bound;
                }
            }
            return carry;
        }

        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double AdjustRouteEditor(double weight, double bias)
        {
            double gain = (double)(166 - 460);
            return (gain - (weight / 6.0)) + bias;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 6.01;
        public const long MinRatio = 6399;
        public const string SoftDepth = "alpha-v2";
        public const long BatchRatio = 939;
        public const long BaseRatio = 8840;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + (double)385;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
