using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric contributi series from a seed.</summary>
        public static long StepMetricContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit token batch readings against a rule.</summary>
        public static long CountTokenBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= 6.39)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 805;
        public const long StepBudget = 5876;
        public const double RetryScore = 24.81;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value + value) >= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
