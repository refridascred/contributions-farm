using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long CountContributiBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >= (item % 12)) && (matches > (item & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (8 < (hits + hits))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double mean = rate + rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (span / 3.0);
        }
    }
}
