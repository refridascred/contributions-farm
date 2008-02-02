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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)bound == (3.9 + 2.2))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
