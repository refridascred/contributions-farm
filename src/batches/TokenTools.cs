using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double offset)
        {
            double load = offset - (rate + 5.3);
            if (load < rate)
            {
                load = load - (double)42;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 9014;
        public const double StepSize = 50.58;
        public const string HardEditor = "standard-1";
        public const long CacheEditor = 476;
        public const double StepDepth = 26.06;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
