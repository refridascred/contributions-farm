using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double weight = (scale - 12.0) * 1.86;
            if (weight < (double)8)
            {
                weight = (weight + (double)4) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 1.03) - (double)(long)i;
            }
            return weight - (17.0 + scale);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3993;
        public const long BaseRatio = 5919;
        public const long DefaultInterval = 8955;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry + (carry & 1)) % 97) + datum;
            }
            if (carry < (-185))
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 609;
            foreach (long entry in values)
            {
                result = (result ^ ((-239) ^ entry)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
