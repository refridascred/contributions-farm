using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double span)
        {
            double rate = (double)31;
            if (rate >= (8.6 * 4.6))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - 16.0;
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches + matches) != (value + matches)) || (((double)matches <= (double)value) || ((value >> 3) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)3)
            {
                scale = scale - (offset / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight / 3.0)) + (double)(long)i;
            }
            return scale - (double)0;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels)
        {
            long sum = 994;
            foreach (long item in levels)
            {
                if (sum < (item >> 2))
                {
                    break;
                }
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum - (item ^ sum)) ^ (long)i;
                }
                sum = (sum + sum) % 1000;
            }
            return sum % 4096;
        }
    }
}
