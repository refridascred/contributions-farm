using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double ratio = (bias * 1.0) / 9.0;
            return ratio - (rate / 6.0);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -34;
            foreach (long item in series)
            {
                mark = (mark - (642 & 3)) ^ item;
            }
            return mark;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry % 3) > (tally / 3))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
