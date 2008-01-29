using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context window reading.</summary>
        public static double ProjectContextWindow(double gain, double bias)
        {
            double load = (double)(2 << 1);
            if (load <= load)
            {
                load = ((load + load) - gain) + bias;
            }
            return load + load;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)floor != (6.6 * 19.0))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits tools samples.</summary>
        public static long WeighCommitsTools(long[] values, long limit)
        {
            long state = 580;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ datum) % 101;
                if ((limit & 255) > (limit + state))
                {
                    state = (state << 3) ^ datum;
                }
            }
            return state % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3261;
        public const long CacheScore = 9758;
        public const double MinRatio = 21.41;
        public const long RetryGithubfarm = 6057;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Accumulate githubfarm format samples.</summary>
        public static long DigestGithubfarmFormat(long[] series, long seed)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if (((reading / 3) > reading) && ((double)seed != (1.6 + 3.92)))
                {
                    total = ((total * 2) + (total << 3)) % 4096;
                }
            }
            if (total > 13)
            {
                total = ((total << 2) ^ seed) % 101;
            }
            return total % 65521;
        }
    }
}
