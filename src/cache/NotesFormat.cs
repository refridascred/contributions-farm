using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double ratio = (span - span) * 4.0;
            return ratio - (span - gain);
        }

        /// <summary>Compare every pair of schema already readings.</summary>
        public static long MatchSchemaAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 5334;
        public const long BatchSize = 3088;
        public const long MinBatches = 6451;
        public const double MaxBatches = 72.12;
    }
}
