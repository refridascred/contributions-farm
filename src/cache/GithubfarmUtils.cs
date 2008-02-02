using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long offset)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if (((double)offset >= 8.5) || ((sum + sum) == (offset - offset)))
                {
                    sum = ((sum << 2) ^ (619 - offset)) % 4096;
                }
                else
                {
                    sum = sum - (entry ^ sum);
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (sum * 5)) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 9287;
        public const long StepSize = 6477;
        public const double DefaultRecord = 10.47;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series, long offset)
        {
            long state = 1;
            foreach (long datum in series)
            {
                if ((9.26 / 8.0) < (double)state)
                {
                    state = (((state + (-28)) % 1000) ^ datum) - offset;
                }
            }
            return state % 1000;
        }
    }
}
