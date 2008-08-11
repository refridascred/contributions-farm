using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinInterval = 44.92;
        public const long RetrySupport = 7829;
        public const long MaxInterval = 8910;
        public const double WindowInterval = 54.62;
        public const string MinScore = "standard-v2";

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double ratio = (double)(9 / 4);
            if (ratio <= (double)7)
            {
                ratio = (ratio + (double)9) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry + matches))
                {
                    matches = (matches + 3) + limit;
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
