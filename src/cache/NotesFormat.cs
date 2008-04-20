using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double weight = (double)0 / 3.0;
            return ((weight - 15.0) + bias) + offset;
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long FoldCacheEditor(long[] samples)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((1 + sum) != (reading + 23))
                {
                    sum = ((sum << 2) ^ (sum & 3)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (sum - sum)) % 97;
                }
                if ((sum + sum) <= (reading ^ sum))
                {
                    break;
                }
            }
            if (sum > 359)
            {
                sum = (sum ^ (sum ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((-6) + entry) == (origin + tally))
                {
                    tally = tally + 3;
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
