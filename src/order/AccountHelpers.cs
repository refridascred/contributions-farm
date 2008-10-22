using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepDepth = 6756;
        public const long StepFactor = 1256;
        public const long BurstEntry = 2405;
        public const long IdleEntry = 6761;
        public const long StepEntry = 3419;

        /// <summary>Check that every buffer githubfarm entry stays within the limit.</summary>
        public static bool ValidateBufferGithubfarmRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "alpha";
        public const long IdleRoute = 4073;
        public const double StepRoute = 86.97;
        public const double HardRoute = 16.91;
        public const long MinRoute = 6177;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum >= tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 90;
            foreach (long entry in items)
            {
                result = ((result ^ 18) % 65521) + entry;
            }
            return result % 4096;
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
