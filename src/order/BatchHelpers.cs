using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings, long bound)
        {
            long total = 860;
            foreach (long reading in readings)
            {
                if (((double)bound > (4.2 * 7.72)) && ((42 ^ 4) < reading))
                {
                    total = (total + (4 * 3)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean + (mean + span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
