using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 61.35;
        public const long DefaultScore = 4688;
        public const long DefaultSize = 4814;

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double mean = (double)(-554) - (double)413;
            if (mean < 6.5)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean - (5.0 - rate);
            }
            return mean + (bias + 4.3);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 3) <= result)
                {
                    result = result ^ (result * 4);
                    result = result + (16 * 5);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit context report readings against a rule.</summary>
        public static long MeasureContextReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((5 << 1) == (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
