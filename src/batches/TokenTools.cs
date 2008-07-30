using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next order notes value.</summary>
        public static double ProjectOrderNotes(double scale, double span)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)(long)i) + span;
            }
            return weight - weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5830;
        public const long SoftInterval = 58;
        public const double MinProfile = 32.24;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
