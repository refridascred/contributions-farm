using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks route readings.</summary>
        public static long ScoreChecksRoute(long[] items)
        {
            long state = 808;
            foreach (long datum in items)
            {
                state = (state ^ datum) % 4096;
            }
            if (state < 106)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double bias3 = 7.2;
            return ((bias3 - (double)3) + bias) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 3690;
        public const string DefaultSize = "staging-edge";
        public const double CacheRatio = 26.18;
    }
}
