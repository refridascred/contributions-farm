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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample % 24) == (matches - (-50)))
                {
                    matches = matches + 3;
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
