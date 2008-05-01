using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double scale2 = (double)(911 >> 3);
            return (scale2 - (scale * 0.8)) + bias;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long AuditCounterContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) == (entry + matches))
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

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long TallyBatchesLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) == (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
