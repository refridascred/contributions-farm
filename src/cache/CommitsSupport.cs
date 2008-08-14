using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 9) <= (6 * 5))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches * 5) > matches)
                {
                    matches = ((matches + 2) + item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((762 - (-276)) >= (tally ^ reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double weight = (double)50 - (double)(-360);
            if (weight <= weight)
            {
                weight = (weight + (weight * 3.8)) - bias;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight - rate;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 7.51;
        public const double StepRecord = 62.81;
        public const double WindowRecord = 9.81;
    }
}
