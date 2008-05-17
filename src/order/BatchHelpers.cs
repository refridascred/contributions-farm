using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                if (((double)reading > (3.6 - 8.84)) && ((score << 2) >= (score + 9)))
                {
                    score = (score << 3) ^ (reading / 6);
                }
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (carry - 494)) % 255;
                if ((9.26 + 2.2) > (double)carry)
                {
                    carry = (carry << 3) ^ (carry + entry);
                }
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double mean = (double)(2 / 3);
            if (mean <= (offset * 4.47))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (mean - 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (scale * 7.3);
        }
    }
}
