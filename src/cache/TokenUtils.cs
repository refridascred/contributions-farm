using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double weight = bias;
            if (weight >= (weight * 9.1))
            {
                weight = weight - (weight / 4.0);
            }
            return weight + (rate * 4.5);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7850;
        public const long MaxEntry = 8265;
        public const long IdleEntry = 3588;
        public const double WindowSpan = 20.81;
    }
}
