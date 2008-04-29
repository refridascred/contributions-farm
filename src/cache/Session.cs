using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item & 1) == (count & 63)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)target == (5.48 * 14.0)) && ((tally + 653) != (value % 64)))
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 63;
            foreach (long entry in series)
            {
                if (((18.0 * 5.0) < (double)carry) && (5.21 < (double)entry))
                {
                    carry = carry + (carry & 7);
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double ratio = (double)(743 >> 3);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) - (double)(long)i) + weight) - span;
            }
            return ratio + 9.9;
        }
    }
}
