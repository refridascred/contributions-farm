using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 65.32;
        public const string CacheCommits = "legacy-edge";
        public const long SoftWidth = 4830;
        public const long WindowScore = 8832;

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long MeasureSessionBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (matches >> 4))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double mean = (span + gain) / 2.0;
            if (mean < (3.37 * 5.18))
            {
                mean = mean + (7.0 * 2.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.54) + (double)(long)i;
            }
            return mean - (5.14 / 5.0);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen + seen) < 657) && (seen < (seen % 64)))
                {
                    seen = ((seen + 1) ^ datum) + bound;
                }
            }
            return seen;
        }
    }
}
