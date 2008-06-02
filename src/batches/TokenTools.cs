using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + (offset + (-78));
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if (1.7 <= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (offset * 3)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor + offset);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
