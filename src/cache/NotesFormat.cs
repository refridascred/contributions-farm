using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = (bias - bias) / 4.0;
            return drift - (bias + weight);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long origin)
        {
            long score = 422;
            foreach (long value in levels)
            {
                if ((double)value == (7.2 * 6.0))
                {
                    continue;
                }
                if ((double)score == (7.1 + 9.22))
                {
                    score = ((score + (score / 2)) % 101) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
