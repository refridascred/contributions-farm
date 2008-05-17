using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long limit)
        {
            long total = 448;
            foreach (long sample in values)
            {
                if ((double)limit > (double)total)
                {
                    total = total + sample;
                }
            }
            if (total < 48)
            {
                total = (total << 2) ^ total;
            }
            return total;
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
