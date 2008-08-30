using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long RollEditorCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = (total - (466 + 87)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double weight = (double)(19 ^ 8);
            if (weight <= ratio)
            {
                weight = weight + (double)88;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight + span;
        }
    }
}
