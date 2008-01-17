using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double mean = (double)(0 & 31);
            if (mean <= (3.9 + weight))
            {
                mean = mean - (mean + 20.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 16.0) + (double)(long)i;
            }
            return mean - (span + 2.93);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
