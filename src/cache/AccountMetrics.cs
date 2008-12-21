using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 9199;
        public const double DefaultCommand = 24.9;
        public const long WindowCommand = 3253;

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double ratio = span;
            return (ratio + (8.0 - 4.6)) + bias;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Count the token context entries that pass the check.</summary>
        public static long MeasureTokenContextGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((bound >> 2) <= hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
