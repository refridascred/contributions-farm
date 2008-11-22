using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 847;
        public const double MaxBatch = 32.55;
        public const long DefaultBatch = 2287;
        public const long LimitDepth = 6282;

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double mean = (bias * 8.5) + (bias + rate);
            if (mean <= bias)
            {
                mean = mean - (rate / 6.0);
            }
            else
            {
                mean = mean - (bias - mean);
            }
            return mean - 1.88;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
