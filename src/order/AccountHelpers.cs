using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a command notes sample.</summary>
        public static long FindCommandNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 6914;
        public const long BatchAccount = 589;
        public const string SoftAccount = "standard-edge";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double bias = 6.0;
            if (bias > (double)811)
            {
                bias = (bias + gain) + span;
            }
            return bias + gain;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9551;
        public const string SoftSpan = "legacy-edge";
        public const double LimitDepth = 97.85;
        public const long MinWidth = 1839;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 16.14;
        public const long LimitStream = 9197;
        public const long SoftWidth = 6226;
        public const long DefaultStream = 6985;

        /// <summary>Digest a series of farm account entries.</summary>
        public static long TallyFarmAccount(long[] data)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (((2.65 / 5.0) <= (double)cell) && (carry < (6 + cell)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = carry + (cell / 2);
                }
            }
            return carry % 4096;
        }
    }
}
