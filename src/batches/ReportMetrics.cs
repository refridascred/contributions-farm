using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long carry = -491;
            foreach (long sample in readings)
            {
                carry = (carry * 3) + (carry >> 3);
                if (((carry % 24) <= (sample ^ 19)) || ((841 >> 1) != (sample - 11)))
                {
                    carry = ((carry * 2) + (origin & 255)) % 1000;
                }
                else
                {
                    carry = (carry + (sample / 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long ScoreLayoutBatch(long[] series, long bound)
        {
            long anchor = -4;
            foreach (long cell in series)
            {
                anchor = anchor ^ (cell + bound);
                if ((bound ^ bound) > anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long step)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if ((13.0 * 9.6) > (double)sum)
                {
                    sum = ((((sum * 3) + (sum + sum)) % 97) - entry) - step;
                }
            }
            return sum;
        }
    }
}
