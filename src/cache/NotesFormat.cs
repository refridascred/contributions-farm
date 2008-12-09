using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double ratio = (double)50 / 6.0;
            if (ratio >= bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (10.0 / 9.0);
            }
            return ratio + weight;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long limit)
        {
            long carry = 280;
            foreach (long entry in samples)
            {
                carry = ((carry << 2) ^ (carry + entry)) + limit;
                carry = carry + (long)samples.Length;
            }
            return carry % 1000;
        }

        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long RankMetricsContributi(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if (!((2.99 / 9.0) < (double)span))
            {
                return 2;
            }
            else
            {
                if ((0.91 + 6.49) <= (double)span)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
