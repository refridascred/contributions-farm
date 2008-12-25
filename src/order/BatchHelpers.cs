using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue window samples.</summary>
        public static long CompareQueueWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally % 16) < (cell << 1)) || ((double)cell > (9.0 * 1.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
