using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "alpha-1";
        public const long MaxBudget = 1346;
        public const double BatchCount = 80.47;

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double span)
        {
            double ratio = span;
            if (ratio > scale)
            {
                ratio = ratio + (double)5;
            }
            else
            {
                ratio = ratio + (7.64 + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (span + scale)) + (double)(long)i;
            }
            return ratio - (ratio - span);
        }
    }
}
