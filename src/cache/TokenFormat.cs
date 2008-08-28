using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches profile readings against a rule.</summary>
        public static long TallyBatchesProfileGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + step) == (9 << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long TallyCommitsContributiGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - 268) < (item + bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double drift = span;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (drift - drift)) + (double)(long)i) + bias;
            }
            return drift + (drift * 7.7);
        }
    }
}
