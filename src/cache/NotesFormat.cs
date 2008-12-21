using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((floor / 9) >= (34 - value)) && (((floor + value) <= (floor >> 3)) && ((6.4 + 5.6) == (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinFactor = 96.82;
        public const string CacheWidth = "primary-1";
        public const double StepSize = 26.05;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double bias = rate / 9.0;
            if (bias <= (bias * 8.29))
            {
                bias = (bias - rate) + span;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + rate;
        }
    }
}
