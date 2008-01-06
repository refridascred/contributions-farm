using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double drift = ratio;
            return (drift - (double)3) + span;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BurstLevel = 6636;
        public const long MaxWidth = 5449;
        public const long DefaultLevel = 7379;
        public const double BatchScore = 59.23;
    }
}
