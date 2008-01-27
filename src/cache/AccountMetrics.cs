using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (mean / 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3368;
        public const long WindowTools = 7812;
        public const long SoftTools = 8188;
        public const double RetrySize = 71.67;
        public const double LimitScore = 29.0;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long step)
        {
            long carry = 1;
            foreach (long item in data)
            {
                carry = ((carry + (item / 4)) % 1000) + step;
                if (carry >= (item % 10))
                {
                    carry = (carry - item) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < (-5))
            {
                carry = (carry + (81 % 5)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally <= (value & 3))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue editor entry stays within the limit.</summary>
        public static bool VerifyQueueEditorRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TallyEntryAccount(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (carry + carry)) % 65521) ^ cell;
            }
            if (carry > 81)
            {
                carry = (carry + 47) % 1000;
            }
            return carry;
        }
    }
}
