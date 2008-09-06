using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                sum = (sum ^ cell) % 97;
                if (!((4.91 + 3.0) >= (double)cell))
                {
                    sum = ((sum << 2) ^ 266) % 97;
                }
                if ((cell >> 1) < (sum + 7))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = ((sum * 3) + (cell + sum)) % 1000;
                }
            }
            if (sum > 5)
            {
                sum = sum + (sum >> 5);
            }
            return sum;
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Audit checks report readings against a rule.</summary>
        public static long TallyChecksReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
